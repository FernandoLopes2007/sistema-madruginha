create database madrugas;
use madrugas;

create table clientes (
cod_cli int auto_increment primary key,
nome_cli varchar(100) not null,
telefone_cli varchar(20) unique,
email_cli varchar(100) unique
);

create table socios (
cod_soc int auto_increment primary key,
nome_soc varchar (100) not null,
email_soc varchar(100) unique,
cpf_soc char(20) not null unique,
telefone_soc char(20) NOT NULL unique
);

create table produtos(
cod_prod int not null primary key,
nome_prod varchar (100) not null,
valor_prod decimal(10,2) check(valor_prod >= 0)
);

create table servicos(
cod_serv int auto_increment primary key,
nome_serv varchar(100) not null,
valor_serv decimal (10,2) not null check(valor_serv >=0)
);

create table funcionarios(
cod_func int auto_increment primary key,
nome_func varchar(100) not null,
telefone_func char(20) unique,
email_func varchar (100) unique,
data_emissao_func datetime default now(),
status_func varchar(25) check(status_func = "Casado" or status_func = "Solteiro"),
endereço_func varchar(200),
sexo_func char (1)  check (sexo_func = "F" or sexo_func = "M"),
senha_func varchar(100) not null
);

create table fornecedores(
cod_forn int auto_increment primary key,
nome_forn varchar(100) not null,
telefone_forn char (20) not null unique,
email_forn varchar(100) not null unique,
endereco_forn varchar(200) not null
);

create table saida(
cod_sai int auto_increment primary key,
descricao_sai varchar (255),
valor_sai decimal (10,2) check(valor_sai >=0 )
);

create table caixa(
cod_caixa int auto_increment primary key,
cod_serv int not null,
cod_sai int not null,
cod_func int not null,
tipo_caixa enum ('entrada', 'saida') not null,
valor_caixa decimal (10,2) not null,
descricao_caixa varchar(255),
data_caixa date not null,
foreign key (cod_serv) references servicos(cod_serv),
foreign key (cod_sai) references saida (cod_sai),
foreign key (cod_func) references funcionarios (cod_func)
);

create table movimentacao_estoque(
cod_movi int auto_increment primary key,
cod_prod int not null,
tipo varchar(25) not null,
quantidade int not null,
data_movimentacao datetime default now(),
saldo decimal(10,2) check(saldo >= 0),
foreign key (cod_prod) references produtos (cod_prod)
);



