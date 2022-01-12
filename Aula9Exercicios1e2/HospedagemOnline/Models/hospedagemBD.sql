create  database HospedagemBD;

use HospedagemBD;

create table estabelecimento (
IdEstabelecimento int not null auto_increment primary key,
NomeComercial varchar(100) not null,
RazaoSocial varchar(100) not null,
CNPJ varchar(14) not null,
Endereco varchar(150) not null,
Telefone varchar(11) not null,
Site varchar(50) not null,
constraint FK_Estabelecimento_IdCidade foreign key(IdCidade) references cidade(IdCidade),
constraint FK_Estabelecimento_IdCidade foreign key(IdCategoria) references categoria(IdCategoria)
);

create table categoria (
IdCategoria int not null auto_increment primary key,
Descricao varchar(50) not null
);

create table cidade (
IdCidade int not null auto_increment primary key,
Nome varchar(80) not null, 
UF varchar(2) not null
);

create table quarto (
IdQuarto int not null auto_increment primary key,
NumeroQuarto int not null,
Disponivel bit not null
foreign key(IdEstabelecimento) references estabelecimento(IdEstabelecimento),
foreign key(IdTipoQuarto) references tipoQuarto(IdTipoQuarto),
constraint Unique_IdEstabelecimentoNumeroQuarto unique (IdEstabelecimento, NumeroQuarto)
);

create table TipoQuarto (
IdTipoQuarto int not null auto_increment primary key,
Descricao varchar(40) not null,
ValorDiaria decimal not null,
CafeManha bit not null
);
