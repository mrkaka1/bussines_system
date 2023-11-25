create database cadastro_funcionario_bd;
use cadastro_funcionario_bd;

create table Funcionario(
id_Fun int primary key auto_increment,
nome_Fun varchar(100),
data_nas_Fun date,
cpf_Fun varchar(21),
rg_Fun varchar(20),
telefone_Fun varchar(50),
email_Fun varchar(200),
endereco_Fun varchar(100),
cidade_Fun varchar(100),
estado_Fun varchar(100),
estado_civil_Fun varchar(100),
funcao_Fun varchar(60),
salario_Fun double
);

create table Empresas (
id_emp integer primary key auto_increment, 
nome_fantasia_emp varchar(200),
razao_social_emp varchar(200),
cnpj_emp varchar(30),
situacao_cadastral_emp varchar(50),
inicio_atvd_emp varchar(100),
endereco_emp varchar(300),
estado_emp varchar(200),
cidade_emp varchar(100),
regime_tributario_emp varchar(200),
tipo_emp varchar(20),
porte_emp varchar(30),
telefone_emp varchar(40),
natureza_juridica_emp varchar(100),
valor_monetario_emp float,
nome_proprietario_emp varchar(200),
cpf_emp varchar(20)
);

select * from Funcionario;
select * from Empresas;
