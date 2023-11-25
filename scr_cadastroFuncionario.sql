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

insert into Empresas values(null, 'Eagle Programmers', 'Programadores S.A', '51.003.938/0001-04', 'Ativa', '2025-05-23', 'Avenida Transcontinental', 'RO', 'Ji-Paraná', 'Real', 'Matriz', 'Pequena',  '(69) 9 9901-3826', 'MEI', 30000, 'Kauan Marques da Luz', '058330532-68');
insert into Empresas values(null, 'TecnoInovação Ltda', 'TecnoInovação Tecnologia e Consultoria Ltda.', '34.697.649/0001-25', 'Suspensa', '2012-01-22', 'Avenida Nova Brasilia', 'DF', 'Distrito Federal', 'Real', 'Filia', 'Grande',  '(69) 9 9901-3826', 'SA', 10000, 'Ana Carolina Santos', '029.093.880-50');
insert into Empresas values(null, 'SaborArte Gastronomia S/A', ' SaborArte Indústria e Comércio de Alimentos S/A', '69.477.841/0001-90', 'Inapta', '2020-05-30', 'Avenida São Paulo', 'SP', 'São Paulo', 'Real', 'Matriz', 'Média',  '(69) 9 9901-3826', 'MEI', 150000, 'Rodrigo Oliveira', '164.673.750-41');
insert into Empresas values(null, 'EcoVida Energia Renovável Ltda.', 'EcoVida Energia Renovável e Sustentabilidade Ltda.', '92.296.623/0001-71', 'Baixada', '2008-09-01', 'Avenida Manguezal', 'BH', 'Salvador', 'Real', 'Filial', 'Grande',  '(69) 9 9901-3826', 'SLP', 200000, 'Marina Silva', '116.944.020-70');
insert into Empresas values(null, 'SoluçõesExpress Logística e Transportes S/A', 'SoluçõesExpress Logística e Transportes S/A', '59.821.470/0001-69', 'Suspensa', '2010-10-10', 'Avenida João Paulo VI', 'RJ', 'Rio de Janeiro', 'Real', 'Matriz', 'Média',  '(69) 9 9999-5826', 'SSL', 150000, 'André Martins', '626.983.600-03');

insert into Funcionario (nome_Fun, data_nas_Fun, cpf_Fun, rg_Fun, telefone_Fun, email_Fun, endereco_Fun, cidade_Fun, estado_Fun, estado_civil_Fun, funcao_Fun, salario_Fun)
values ('João Silva', '1990-05-15', '123.456.789-09', '98765432-X', '(11) 1234-5678', 'joao.silva@email.com', 'Rua A, 123', 'São Paulo', 'SP', 'Solteiro', 'Analista de TI', 5000.00);

insert into Funcionario (nome_Fun, data_nas_Fun, cpf_Fun, rg_Fun, telefone_Fun, email_Fun, endereco_Fun, cidade_Fun, estado_Fun, estado_civil_Fun, funcao_Fun, salario_Fun)
values ('Maria Oliveira', '1985-08-20', '987.654.321-09', '12345678-Y', '(21) 9876-5432', 'maria.oliveira@email.com', 'Avenida B, 456', 'Rio de Janeiro', 'RJ', 'Casada', 'Gerente de Vendas', 7000.00);

insert into Funcionario (nome_Fun, data_nas_Fun, cpf_Fun, rg_Fun, telefone_Fun, email_Fun, endereco_Fun, cidade_Fun, estado_Fun, estado_civil_Fun, funcao_Fun, salario_Fun)
values('Carlos Santos', '1982-03-10', '111.222.333-44', '87654321-Z', '(31) 5555-8888', 'carlos.santos@email.com', 'Rua C, 789', 'Belo Horizonte', 'MG', 'Divorciado', 'Analista Financeiro', 6000.00);

insert into Funcionario (nome_Fun, data_nas_Fun, cpf_Fun, rg_Fun, telefone_Fun, email_Fun, endereco_Fun, cidade_Fun, estado_Fun, estado_civil_Fun, funcao_Fun, salario_Fun)
values ('Fernanda Lima', '1995-11-25', '555.666.777-88', '13579246-W', '(41) 3333-9999', 'fernanda.lima@email.com', 'Rua D, 321', 'Curitiba', 'PR', 'Solteira', 'Assistente Administrativo', 4500.00);

insert into Funcionario (nome_Fun, data_nas_Fun, cpf_Fun, rg_Fun, telefone_Fun, email_Fun, endereco_Fun, cidade_Fun, estado_Fun, estado_civil_Fun, funcao_Fun, salario_Fun)
values ('Lucas Pereira', '1988-07-12', '444.555.666-77', '98765432-X', '(51) 2222-7777', 'lucas.pereira@email.com', 'Avenida E, 555', 'Porto Alegre', 'RS', 'Casado', 'Engenheiro de Software', 8000.00);
