# 5 CONSULTAS (INNER JOIN, LEFT JOIN, RIGHT JOIN);

-- 1 Lista os livros e as categorias.
SELECT l.titulo AS Título, c.nome AS Categoria FROM Categoria AS c
	RIGHT JOIN Livro AS l ON c.id_categoria = l.id_categoria_fk;

-- 2 Lista os livros com editoras. 
SELECT l.id_livro, l.titulo, e.nome_fantasia AS Editora FROM Livro AS l
	LEFT JOIN Editora AS e ON e.id_editora = l.id_editora_fk;

-- 3 Quantidade de exemplares por livro e situação.
SELECT e.id_exemplar, e.quant  AS 'Quantidade', s.situacao AS Situação, l.titulo AS Título FROM Exemplar AS e
	INNER JOIN _Status AS s ON e.id_status_fk = s.id_status
	INNER JOIN Livro AS l ON e.id_livro_fk = l.id_livro;

-- 4 Lista histórico de empréstimos com informações de usuário, funcionário e livro.
SELECT e.id_emprestimo, u.nome AS Usuário, f.nome AS Funcionário, l.titulo AS Livro, e.data_emprestimo, 
e.dataPrevi_devolucao  AS 'Data Prevista para  Devolução', e.data_devolucao FROM Emprestimo AS e
	INNER JOIN Usuario AS u ON u.id_usuario = e.id_usuario_fk
	INNER JOIN Funcionario AS f ON e.id_funcionario_fk = f.id_funcionario
	INNER JOIN Exemplar AS ex ON e.id_exemplar_fk = ex.id_exemplar
	INNER JOIN Livro AS l ON ex.id_livro_fk = l.id_livro;

-- 5 Lista livros com e sem autores.
  SELECT l.id_livro, l.titulo, a.nome AS Autor FROM Livro AS l
	LEFT JOIN Autor_Livro al ON l.id_livro = al.id_livro_fk
	LEFT JOIN Autor AS a ON al.id_autor_fk = a.id_autor;


# 3 SUBCONSULTAS

-- 1 Encontrar usuários que pegaram emprestado livros que ainda não foram devolvidos.
SELECT u.id_usuario, u.nome FROM Usuario AS u
	WHERE u.id_usuario IN (SELECT id_usuario_fk FROM Emprestimo
		WHERE data_devolucao IS NULL);

-- 2 Liste todos os exemplares que estão disponíveis.
SELECT e.id_exemplar, e.estado_fisico AS 'Estado Físico', l.titulo AS Livro FROM Exemplar AS e
	INNER JOIN Livro AS l ON e.id_livro_fk = l.id_livro
		WHERE e.id_status_fk = (SELECT id_status FROM _Status WHERE situacao = 'disponível');

-- 3 Liste os nomes dos autores que possuem pelo menos um livro publicado após o ano de 2020
SELECT a.nome FROM Autor AS a
	WHERE a.id_autor IN (SELECT al.id_autor_fk FROM Autor_Livro AS al
		INNER JOIN Livro AS l ON al.id_livro_fk = l.id_livro
			WHERE l.ano_publicacao > 2020);


# 2 GROUP BY

-- 1 Quantidade de livros em cada Categoria
SELECT c.nome AS Categoria, COUNT(l.id_livro) AS 'Quantidade de Livros' FROM Categoria AS c
	LEFT JOIN Livro AS l ON c.id_categoria = l.id_categoria_fk
		GROUP BY c.nome;

-- 2 Listar autores que possuem mais de 1 livro cadastrado
SELECT a.nome AS Autor, COUNT(al.id_livro_fk) AS 'Quantidade de Livros' FROM Autor AS a
	INNER JOIN Autor_Livro AS al ON al.id_autor_fk = a.id_autor
		GROUP BY a.nome HAVING COUNT(al.id_livro_fk) > 1;