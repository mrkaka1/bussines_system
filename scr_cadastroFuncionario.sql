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

select * from Funcionario;
