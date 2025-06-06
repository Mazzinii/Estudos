CREATE DATABASE DBSemConstraints;
Use DBSemConstraints;

CREATE TABLE Client(
	id_client INT,
	nome_cliente INT,
	genero VARCHAR(100),
	data_de_nascimento DATE,
	cpf VARCHAR(15)
);

CREATE TABLE Gerente (
	id_gerente INT,
	nome_gerente VARCHAR(100),
	data_contratacao VARCHAR(100),
	salario FLOAT
);

CREATE TABLE Contratos(
	id_contrato INT,
	data_assinatura DATE,
	id_cliente INT,
	valor_contrato FLoat
);

SELECT * FROM Client
