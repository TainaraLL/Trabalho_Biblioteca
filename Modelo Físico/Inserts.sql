-- INSERT CATEGORIA 

INSERT INTO Categoria (id_categoria, nome) VALUES (1, 'Fantasia');
INSERT INTO Categoria (id_categoria, nome) VALUES (2, 'Ficção Científica');
INSERT INTO Categoria (id_categoria, nome) VALUES (3, 'Romance');
INSERT INTO Categoria (id_categoria, nome) VALUES (4, 'Aventura');
INSERT INTO Categoria (id_categoria, nome) VALUES (5, 'Mistério');
INSERT INTO Categoria (id_categoria, nome) VALUES (6, 'Terror');
INSERT INTO Categoria (id_categoria, nome) VALUES (7, 'Drama');
INSERT INTO Categoria (id_categoria, nome) VALUES (8, 'Suspense');
INSERT INTO Categoria (id_categoria, nome) VALUES (9, 'História');
INSERT INTO Categoria (id_categoria, nome) VALUES (10, 'Biografia');
INSERT INTO Categoria (id_categoria, nome) VALUES (11, 'Infantil');
INSERT INTO Categoria (id_categoria, nome) VALUES (12, 'Young Adult');
INSERT INTO Categoria (id_categoria, nome) VALUES (13, 'Mitologia');
INSERT INTO Categoria (id_categoria, nome) VALUES (14, 'Cyberpunk');
INSERT INTO Categoria (id_categoria, nome) VALUES (15, 'Clássicos');
INSERT INTO Categoria (id_categoria, nome) VALUES (16, 'Distopia');
INSERT INTO Categoria (id_categoria, nome) VALUES (17, 'Poesia');
INSERT INTO Categoria (id_categoria, nome) VALUES (18, 'Contos');
INSERT INTO Categoria (id_categoria, nome) VALUES (19, 'Ficção Sobrenatural');
INSERT INTO Categoria (id_categoria, nome) VALUES (20, 'Alta Fantasia');


-- INSERT CARGO 

INSERT INTO Cargo (id_cargo, nome) VALUES (1, 'Bibliotecário');
INSERT INTO Cargo (id_cargo, nome) VALUES (2, 'Atendente');
INSERT INTO Cargo (id_cargo, nome) VALUES (3, 'Gerente');
INSERT INTO Cargo (id_cargo, nome) VALUES (4, 'Auxiliar Administrativo');
INSERT INTO Cargo (id_cargo, nome) VALUES (5, 'Estagiário');
INSERT INTO Cargo (id_cargo, nome) VALUES (6, 'Catalogador');
INSERT INTO Cargo (id_cargo, nome) VALUES (7, 'Assistente de Acervo');
INSERT INTO Cargo (id_cargo, nome) VALUES (8, 'Supervisor');
INSERT INTO Cargo (id_cargo, nome) VALUES (9, 'Analista de Sistemas');
INSERT INTO Cargo (id_cargo, nome) VALUES (10, 'Gestor de Patrimônio');
INSERT INTO Cargo (id_cargo, nome) VALUES (11, 'Arquivista');
INSERT INTO Cargo (id_cargo, nome) VALUES (12, 'Consultor Externo');
INSERT INTO Cargo (id_cargo, nome) VALUES (13, 'Mediador Cultural');
INSERT INTO Cargo (id_cargo, nome) VALUES (14, 'Conservador');
INSERT INTO Cargo (id_cargo, nome) VALUES (15, 'Auxiliar de Serviços Gerais');
INSERT INTO Cargo (id_cargo, nome) VALUES (16, 'Segurança');
INSERT INTO Cargo (id_cargo, nome) VALUES (17, 'Recepcionista');
INSERT INTO Cargo (id_cargo, nome) VALUES (18, 'Coordenador');
INSERT INTO Cargo (id_cargo, nome) VALUES (19, 'Consultor Técnico');
INSERT INTO Cargo (id_cargo, nome) VALUES (20, 'Diretor');


-- INSERT STATUS

INSERT INTO _Status (id_status, situacao) VALUES (1, 'disponível');
INSERT INTO _Status (id_status, situacao) VALUES (2, 'emprestado');
INSERT INTO _Status (id_status, situacao) VALUES (3, 'danificado');
INSERT INTO _Status (id_status, situacao) VALUES (4, 'em manutenção');
INSERT INTO _Status (id_status, situacao) VALUES (5, 'perdido');
INSERT INTO _Status (id_status, situacao) VALUES (6, 'extraviado');
INSERT INTO _Status (id_status, situacao) VALUES (7, 'aguardando reposição');
INSERT INTO _Status (id_status, situacao) VALUES (8, 'aguardando avaliação');
INSERT INTO _Status (id_status, situacao) VALUES (9, 'substituição pendente');
INSERT INTO _Status (id_status, situacao) VALUES (10, 'pendente de devolução');
INSERT INTO _Status (id_status, situacao) VALUES (11, 'renovado');
INSERT INTO _Status (id_status, situacao) VALUES (12, 'atrasado');
INSERT INTO _Status (id_status, situacao) VALUES (13, 'coleta agendada');
INSERT INTO _Status (id_status, situacao) VALUES (14, 'em limpeza');
INSERT INTO _Status (id_status, situacao) VALUES (15, 'em análise');
INSERT INTO _Status (id_status, situacao) VALUES (16, 'defeituoso');
INSERT INTO _Status (id_status, situacao) VALUES (17, 'novo');
INSERT INTO _Status (id_status, situacao) VALUES (18, 'reposto');
INSERT INTO _Status (id_status, situacao) VALUES (19, 'separado para descarte');
INSERT INTO _Status (id_status, situacao) VALUES (20, 'rasurado');


-- INSERT AUTOR

INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (1, 'Lauren Roberts', 'Estados Unidos', '1995-08-14');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (2, 'Abigail Owen', 'Estados Unidos', '1980-05-12');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (3, 'J. K. Rowling', 'Reino Unido', '1965-07-31');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (4, 'J. R. R. Tolkien', 'Reino Unido', '1892-01-03');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (5, 'George R. R. Martin', 'Estados Unidos', '1948-09-20');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (6, 'Suzanne Collins', 'Estados Unidos', '1962-08-10');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (7, 'Rick Riordan', 'Estados Unidos', '1964-06-05');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (8, 'Neil Gaiman', 'Reino Unido', '1960-11-10');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (9, 'Stephen King', 'Estados Unidos', '1947-09-21');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (10, 'Agatha Christie', 'Reino Unido', '1890-09-15');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (11, 'C. S. Lewis', 'Reino Unido', '1898-11-29');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (12, 'Veronica Roth', 'Estados Unidos', '1988-08-19');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (13, 'Isaac Asimov', 'Estados Unidos', '1920-01-02');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (14, 'Orson Scott Card', 'Estados Unidos', '1951-08-24');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (15, 'William Shakespeare', 'Reino Unido', '1564-04-26');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (16, 'Machado de Assis', 'Brasil', '1839-06-21');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (17, 'Clarice Lispector', 'Brasil', '1920-12-10');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (18, 'H. P. Lovecraft', 'Estados Unidos', '1890-08-20');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (19, 'Mary Shelley', 'Reino Unido', '1797-08-30');
INSERT INTO Autor (id_autor, nome, nacionalidade, data_nascimento) VALUES (20, 'Margaret Atwood', 'Canadá', '1939-11-18');


-- INSERT ENDEREÇO

INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (1, 'Rondônia', 'Ji-Paraná', 'Pinheiros', 'Rua das Figueiras', 120);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (2, 'Rio de Janeiro', 'Rio de Janeiro', 'Copacabana', 'Avenida Atlântica', 987);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (3, 'Minas Gerais', 'Belo Horizonte', 'Savassi', 'Rua Pernambuco', 455);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (4, 'Bahia', 'Salvador', 'Barra', 'Rua Almirante Marques', 32);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (5, 'Paraná', 'Curitiba', 'Batel', 'Rua Coronel Dulcídio', 210);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (6, 'Rio Grande do Sul', 'Porto Alegre', 'Moinhos de Vento', 'Rua Félix da Cunha', 765);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (7, 'Pernambuco', 'Recife', 'Boa Viagem', 'Rua Setúbal', 112);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (8, 'Ceará', 'Fortaleza', 'Aldeota', 'Rua Barbosa de Freitas', 909);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (9, 'Pará', 'Belém', 'Nazaré', 'Avenida Nazaré', 55);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (10, 'Santa Catarina', 'Florianópolis', 'Trindade', 'Rua Lauro Linhares', 1400);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (11, 'Goiás', 'Goiânia', 'Setor Bueno', 'Rua T-37', 380);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (12, 'Distrito Federal', 'Brasília', 'Asa Sul', 'SQN 210 Bloco F', 10);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (13, 'Espírito Santo', 'Vitória', 'Praia do Canto', 'Rua Aleixo Neto', 670);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (14, 'Mato Grosso', 'Cuiabá', 'Araés', 'Rua Presidente Marques', 99);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (15, 'Mato Grosso do Sul', 'Campo Grande', 'Centro', 'Rua 14 de Julho', 433);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (16, 'Amazonas', 'Manaus', 'Adrianópolis', 'Avenida André Araújo', 101);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (17, 'Paraíba', 'João Pessoa', 'Tambaú', 'Avenida Almirante Tamandaré', 24);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (18, 'Rio Grande do Norte', 'Natal', 'Ponta Negra', 'Rua Praia de Pipa', 312);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (19, 'Maranhão', 'São Luís', 'Renascença', 'Avenida dos Holandeses', 520);
INSERT INTO Endereco (id_endereco, estado, cidade, bairro, rua, num_casa) VALUES (20, 'Sergipe', 'Aracaju', 'Atalaia', 'Avenida Santos Dumont', 801);


-- INSERT USUÁRIO

INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (1, '(11) 98811-2211', '123.456.789-01', 'ana.silva@gmail.com', 'Tony Stark', 1);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (2, '(21) 99722-3322', '234.567.890-12', 'bruno.medeiros@gmail.com', 'Bruce Medeiros', 2);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (3, '(31) 98455-1100', '345.678.901-23', 'carla.rocha@gmail.com', 'Diana Rocha', 3);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (4, '(41) 98123-4556', '456.789.012-34', 'daniel.souza@hotmail.com', 'Joelson Souza', 4);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (5, '(51) 98988-7766', '567.890.123-45', 'elisa.monteiro@yahoo.com', 'Julio Monteiro', 5);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (6, '(61) 98412-6677', '678.901.234-56', 'fabio.santana@gmail.com', 'Fabricio Santana', 6);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (7, '(71) 98777-4422', '789.012.345-67', 'giovanna.ramos@gmail.com', 'Pedro Ramos', 7);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (8, '(81) 98333-9988', '890.123.456-78', 'heitor.lopes@gmail.com', 'Heitor Lopes', 8);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (9, '(91) 98221-5566', '901.234.567-89', 'isabela.ferraz@gmail.com', 'Barry Ferraz', 9);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (10, '(85) 98114-3322', '012.345.678-90', 'joao.paiva@gmail.com', 'Bart Paiva', 10);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (11, '(12) 98877-6655', '111.222.333-44', 'karla.menezes@gmail.com', 'Julia Menezes', 11);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (12, '(13) 98444-2211', '222.333.444-55', 'luan.castro@gmail.com', 'Laura Castro', 12);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (13, '(14) 98712-4433', '333.444.555-66', 'marina.vargas@gmail.com', 'Lorena Vargas', 13);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (14, '(15) 98122-8899', '444.555.666-77', 'nathan.souza@gmail.com', 'Martins Souza', 14);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (15, '(16) 98834-1122', '555.666.777-88', 'olivia.freitas@gmail.com', 'Otavio Freitas', 15);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (16, '(17) 98911-3344', '666.777.888-99', 'paulo.castro@gmail.com', 'Paulo Santos', 16);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (17, '(18) 98255-6677', '777.888.999-00', 'queila.lopes@gmail.com', 'Queila Lopes', 17);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (18, '(19) 98199-2233', '888.999.000-11', 'rafael.torres@gmail.com', 'Rafael Torres', 18);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (19, '(22) 98466-7788', '999.000.111-22', 'sabrina.pereira@gmail.com', 'Sabrina Pereira', 19);
INSERT INTO Usuario (id_usuario, telefone, cpf, email, nome, id_endereco_fk) VALUES (20, '(24) 98788-4411', '000.111.222-33', 'tiago.miranda@gmail.com', 'Bruno Miranda', 20);


-- INSERT FUNCIONÁRIO

INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (1, '11999887766', '12345678901', 'ana.silva@biblioteca.com', 'Ana Silva', 1, 1);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (2, '11988776655', '98765432100', 'bruno.souza@biblioteca.com', 'Bruno Souza', 2, 2);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (3, '11977665544', '32165498700', 'carla.pereira@biblioteca.com', 'Carla Pereira', 3, 3);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (4, '11966554433', '45678912300', 'daniel.mendes@biblioteca.com', 'Daniel Mendes', 4, 4);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (5, '11955443322', '78912345600', 'erika.lima@biblioteca.com', 'Erika Lima', 5, 5);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (6, '11944332211', '15975346800', 'fabio.ramos@biblioteca.com', 'Fábio Ramos', 6, 6);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (7, '11933221100', '85214796300', 'giovana.morais@biblioteca.com', 'Giovana Morais', 7, 7);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (8, '11922110099', '14725836900', 'henrique.alves@biblioteca.com', 'Henrique Alves', 8, 8);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (9, '11911009988', '96325874100', 'isabela.rocha@biblioteca.com', 'Isabela Rocha', 9, 9);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (10, '11900998877', '74185296300', 'joao.cardoso@biblioteca.com', 'João Cardoso', 10, 10);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (11, '11899887766', '36925814700', 'karina.santos@biblioteca.com', 'Karina Santos', 11, 11);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (12, '11888776655', '25814736900', 'leonardo.ferreira@biblioteca.com', 'Leonardo Ferreira', 12, 12);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (13, '11877665544', '45612378900', 'mariana.teixeira@biblioteca.com', 'Mariana Teixeira', 13, 13);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (14, '11866554433', '65498712300', 'nicolas.dutra@biblioteca.com', 'Nicolas Dutra', 14, 14);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (15, '11855443322', '95175384200', 'olivia.campos@biblioteca.com', 'Olivia Campos', 15, 15);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (16, '11844332211', '35795146800', 'paulo.martins@biblioteca.com', 'Paulo Martins', 16, 16);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (17, '11833221100', '78965412300', 'quenia.farias@biblioteca.com', 'Quênia Farias', 17, 17);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (18, '11822110099', '12378945600', 'ricardo.moreira@biblioteca.com', 'Ricardo Moreira', 18, 18);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (19, '11811009988', '85296314700', 'sabrina.gomes@biblioteca.com', 'Sabrina Gomes', 19, 19);
INSERT INTO Funcionario (id_funcionario, telefone, cpf, email, nome, id_endereco_fk, id_cargo_fk) VALUES (20, '11800998877', '95145675300', 'thiago.araujo@biblioteca.com', 'Thiago Araújo', 20, 20);


-- INSERT EDITORA

INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (1, '(11) 3000-1122', '11.111.111/0001-11', 'contato@aurorabooks.com', 'Aurora Books', 1);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (2, '(21) 3555-2211', '22.222.222/0001-22', 'editorial@estreladomar.com', 'Estrela do Mar Editora', 2);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (3, '(31) 3666-3344', '33.333.333/0001-33', 'suporte@penadourada.com', 'Pena Dourada', 3);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (4, '(41) 3777-4455', '44.444.444/0001-44', 'atendimento@luzelivros.com', 'Luze Livros', 4);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (5, '(69) 3888-5566', '55.555.555/0001-55', 'editor@grifoeditorial.com', 'Grifo Editorial', 5);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (6, '(61) 3222-4455', '66.666.666/0001-66', 'contato@florestaeditora.com', 'Floresta Editora', 6);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (7, '(71) 3444-7788', '77.777.777/0001-77', 'email@oceanoeditorial.com', 'Oceano Editorial', 7);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (8, '(81) 3555-8899', '88.888.888/0001-88', 'fale@harmonialivros.com', 'Harmonia Livros', 8);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (9, '(69) 3666-9900', '99.999.999/0001-99', 'contato@arcanapress.com', 'Arcana Press', 9);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (10, '(85) 3001-2233', '10.000.000/0001-00', 'editorial@ventoeditorial.com', 'Vento Editorial', 10);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (11, '(12) 3900-1122', '11.000.001/0001-11', 'contato@prismaliterario.com', 'Prisma Literário', 11);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (12, '(13) 3800-2211', '12.000.002/0001-12', 'editor@folhaverde.com', 'Folha Verde Editora', 12);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (13, '(14) 3700-3344', '13.000.003/0001-13', 'email@universolivros.com', 'Universo Livros', 13);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (14, '(69) 3600-4455', '14.000.004/0001-14', 'contato@cosmoseditora.com', 'Cosmos Editora', 14);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (15, '(16) 3500-5566', '15.000.005/0001-15', 'suporte@viaLacteaeditorial.com', 'Via Láctea Editorial', 15);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (16, '(17) 3400-6677', '16.000.006/0001-16', 'contato@auroraprime.com', 'Aurora Prime', 16);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (17, '(18) 3300-7788', '17.000.007/0001-17', 'editor@solarisbooks.com', 'Solaris Books', 17);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (18, '(19) 3200-8899', '18.000.008/0001-18', 'contato@galaxiapress.com', 'Galáxia Press', 18);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (19, '(69) 3100-9900', '19.000.009/0001-19', 'atendimento@editoralotus.com', 'Editora Lotus', 19);
INSERT INTO Editora (id_editora, telefone, cnpj, email, nome_fantasia, id_endereco_fk) VALUES (20, '(24) 3999-1122', '20.000.010/0001-20', 'email@aurorapublish.com', 'Aurora Publish', 20);


-- INSERT LIVRO

INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (1, 'Powerless', 2023, 1, 'Romance de fantasia com reinos e poderes.', 'Primeiro livro de Abigail.', '978000000001', 1, 11);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (2, 'Os Jogos dos Deuses', 2024, 1, 'Fantasia épica sobre conflitos entre deuses.', 'Livro famoso de Abigail.', '978000000002', 1, 11);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk) 
VALUES (3,'O Hobbit',1937,1,'A jornada de Bilbo Bolseiro.','Clássico da fantasia.','9780547928227',1,1);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (4,'1984',1949,1,'Sociedade distópica totalitária.','Obra de George Orwell.','9780451524935',6,3);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (5,'Harry Potter e a Pedra Filosofal',1997,1,'O início da saga Harry Potter.','Magia e aventura.','9788532511010',11,4);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (6,'O Iluminado',1977,1,'Terror psicológico no Overlook Hotel.','Stephen King.','9780307743657',4,5);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (7,'Coraline',2002,1,'Garota encontra um mundo alternativo.','Neil Gaiman.','9780380807345',18,5);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (8,'Percy Jackson: O Ladrão de Raios',2005,1,'Mitologia grega moderna.','Rick Riordan.','9780786838653',19,8);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (9,'Neuromancer',1984,1,'Cyberpunk clássico.','Obra seminal de William Gibson.','9780441569595',17,17);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (10,'Dom Casmurro',1899,1,'Clássico brasileiro.','Machado de Assis.','9788520920007',8,18);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (11,'O Pequeno Príncipe',1943,1,'Clássico infantil.','Saint-Exupéry.','9780156012195',11,13);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (12,'Drácula',1897,1,'Vampiro icônico.','Bram Stoker.','9780486411095',4,3);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (13,'A Metamorfose',1915,1,'Kafka e o absurdo.','Clássico existencialista.','9780553213690',16,18);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (14,'A Revolução dos Bichos',1945,1,'Sátira política.','George Orwell.','9780451526342',6,3);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (15,'O Nome do Vento',2007,1,'Fantasia épica moderna.','Patrick Rothfuss.','9780756404741',1,14);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (16,'It: A Coisa',1986,1,'Terror sobrenatural.','Stephen King.','9781501142970',4,5);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (17,'A Casa de Hades',2013,1,'Mitologia e aventura.','Rick Riordan.','9781423146728',19,8);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (18,'A Menina que Roubava Livros',2005,1,'Drama na Segunda Guerra.','Markus Zusak.','9780375842207',7,3);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (19,'O Código Da Vinci',2003,1,'Suspense envolvendo simbologia.','Dan Brown.','9780307474278',9,1);
INSERT INTO Livro (id_livro, titulo, ano_publicacao, edicao, sinopse, descricao, isbn, id_categoria_fk, id_editora_fk)
VALUES (20,'Cem Anos de Solidão',1967,1,'Realismo mágico.','Gabriel García Márquez.','9780307474728',20,10);


-- INSERT EXEMPLAR

INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (1, 1, 'novo', 1, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (2, 2, 'usado', 20, 4);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (3, 1, 'bom', 2, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (4, 1, 'danificado', 3, 5);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (5, 1, 'novo', 4, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (6, 2, 'usado', 19, 2);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (7, 1, 'bom', 5, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (8, 1, 'novo', 6, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (9, 1, 'usado', 7, 3);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (10, 1, 'novo', 8, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (11, 1, 'bom', 18, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (12, 2, 'usado', 9, 4);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (13, 1, 'novo', 10, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (14, 1, 'bom', 11, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (15, 1, 'usado', 12, 2);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (16, 1, 'danificado', 13, 5);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (17, 1, 'novo', 14, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (18, 1, 'bom', 15, 1);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (19, 1, 'usado', 16, 3);
INSERT INTO Exemplar (id_exemplar, quant, estado_fisico, id_livro_fk, id_status_fk) VALUES (20, 1, 'novo', 17, 1);


-- INSERT EMPRÉSTIMO

INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(1, '2025-01-10', '2025-01-17', '2025-01-17', 'Devolvido no prazo.', 1, 1, 1);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(2, '2025-01-12', NULL, '2025-01-19', 'Em aberto.', 2, 2, 2);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(3, '2025-01-15', '2025-01-20', '2025-01-22', 'Devolvido adiantado.', 3, 3, 3);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(4, '2025-01-18', NULL, '2025-01-25', 'Atrasado.', 4, 4, 4);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(5, '2025-01-20', '2025-01-29', '2025-01-27', 'Devolvido com atraso.', 5, 5, 5);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(6, '2025-01-22', NULL, '2025-01-29', 'Em aberto.', 6, 6, 6);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(7, '2025-01-25', '2025-01-30', '2025-02-01', 'Devolvido no prazo.', 7, 7, 7);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(8, '2025-01-28', NULL, '2025-02-04', 'Em aberto.', 8, 8, 8);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(9, '2025-01-30', '2025-02-05', '2025-02-06', 'Devolvido adiantado.', 9, 9, 9);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(10, '2025-02-01', NULL, '2025-02-08', 'Atrasado.', 10, 10, 10);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(11, '2025-02-02', '2025-02-10', '2025-02-09', 'Devolvido com leve atraso.', 11, 11, 11);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(12, '2025-02-04', NULL, '2025-02-11', 'Em aberto.', 12, 12, 12);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(13, '2025-02-06', '2025-02-15', '2025-02-14', 'Devolvido.', 13, 13, 13);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(14, '2025-02-08', NULL, '2025-02-15', 'Atrasado.', 14, 14, 14);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(15, '2025-02-10', '2025-02-18', '2025-02-17', 'Devolução dentro do esperado.', 15, 15, 15);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(16, '2025-02-11', NULL, '2025-02-18', 'Em aberto.', 16, 16, 16);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(17, '2025-02-13', '2025-02-20', '2025-02-21', 'Devolvido antes do previsto.', 17, 17, 17);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(18, '2025-02-15', NULL, '2025-02-22', 'Em aberto.', 18, 18, 18);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(19, '2025-02-16', '2025-02-24', '2025-02-23', 'Devolvido com pequeno atraso.', 19, 19, 19);
INSERT INTO Emprestimo (id_emprestimo, data_emprestimo, data_devolucao, dataPrevi_devolucao, observacao, id_usuario_fk, id_funcionario_fk, id_exemplar_fk) VALUES 
(20, '2025-02-18', NULL, '2025-02-25', 'Atrasado.', 20, 20, 20);


-- INSERT AUTOR_LIVRO

INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (1, 1, 1);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (2, 1, 2);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (3, 2, 2);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (4, 3, 3);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (5, 4, 4);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (6, 5, 5);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (7, 6, 6);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (8, 7, 7);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (9, 8, 8);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (10, 9, 9);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (11, 10, 10);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (12, 11, 11);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (13, 12, 12);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (14, 13, 13);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (15, 14, 14);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (16, 15, 15);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (17, 16, 16);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (18, 17, 17);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (19, 18, 18);
INSERT INTO Autor_Livro (id_autor_livro, id_autor_fk, id_livro_fk) VALUES (20, 19, 19);