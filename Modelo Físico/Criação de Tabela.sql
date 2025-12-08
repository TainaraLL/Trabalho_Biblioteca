create database biblioteca_leal;
use biblioteca_leal;

-- DROP schema biblioteca_leal;

create table Categoria (
id_categoria int primary key auto_increment,
nome varchar(20)
);

create table Cargo (
id_cargo int primary key auto_increment,
nome varchar(50)
);

create table _Status (
id_status int primary key auto_increment,
situacao varchar(50)
);

create table Autor (
id_autor int primary key auto_increment,
nome varchar(100),
nacionalidade varchar(50),
data_nascimento date
);

create table Endereco (
id_endereco int primary key auto_increment,
estado varchar(50),
cidade varchar(50),
bairro varchar(100),
rua varchar(100),
num_casa int
);

create table Usuario (
id_usuario int primary key auto_increment,
telefone varchar(20),
cpf varchar(20),
email varchar(100),
nome varchar(200),
id_endereco_fk int not null,
foreign key (id_endereco_fk) references Endereco (id_endereco)
);

create table Funcionario (
id_funcionario int primary key auto_increment,
telefone varchar(20),
cpf varchar(20),
email varchar(100),
nome varchar(200),
id_endereco_fk int not null,
foreign key (id_endereco_fk) references Endereco (id_endereco),
id_cargo_fk int not null,
foreign key (id_cargo_fk) references Cargo (id_cargo)
);

create table Editora (
id_editora int primary key auto_increment,
telefone varchar(20),
cnpj varchar(20),
email varchar(100),
nome_fantasia varchar(100),
id_endereco_fk int not null,
foreign key (id_endereco_fk) references Endereco (id_endereco)
);

create table Livro (
id_livro int primary key auto_increment,
titulo varchar(50),
ano_publicacao int,
edicao int,
sinopse text,
descricao text,
isbn varchar(20),
id_categoria_fk int not null, 
foreign key (id_categoria_fk) references Categoria (id_categoria),
id_editora_fk int not null,
foreign key (id_editora_fk) references Editora (id_editora) 
);

create table Exemplar (
id_exemplar int primary key auto_increment,
quant int,
estado_fisico varchar(20),
id_livro_fk int not null, 
foreign key (id_livro_fk) references Livro (id_livro),
id_status_fk int not null,
foreign key (id_status_fk) references _Status (id_status)
);

create table Emprestimo (
id_emprestimo int primary key auto_increment,
data_emprestimo date,
data_devolucao date,
dataPrevi_devolucao date,
observacao text,
id_usuario_fk int not null,
foreign key (id_usuario_fk) references Usuario (id_usuario),
id_funcionario_fk int not null,
foreign key (id_funcionario_fk) references Funcionario (id_funcionario),
id_exemplar_fk int not null,
foreign key (id_exemplar_fk) references Exemplar (id_exemplar)
);

create table Autor_Livro (
id_autor_livro int primary key auto_increment,
id_autor_fk int not null,
foreign key (id_autor_fk) references Autor (id_autor),
id_livro_fk int not null,
foreign key (id_livro_fk) references Livro (id_livro)
);