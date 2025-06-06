CREATE DATABASE DBComConstraints;
Use DBComConstraints;

CREATE TABLE Cliente(
	id_cliente INT,
	nome_cliente INT NOT NULL,
	genero VARCHAR(100) NOT NULL,
	data_de_nascimento DATE NOT NULL,
	cpf VARCHAR(15) NOT NULL
	CONSTRAINT id_cliente_pk PRIMARY KEY (id_cliente)
);

CREATE TABLE Gerente (
	id_gerente INT,
	nome_gerente VARCHAR(100) NOT NULL,
	data_contratacao VARCHAR(100) NOT NULL,
	salario FLOAT NOT NULL,
	CONSTRAINT id_gerente_pk PRIMARY KEY (id_gerente)
);

CREATE TABLE Contratos(
	id_contrato INT,
	data_assinatura DATE,
	id_cliente INT,
	id_gerente INT,
	valor_contrato FLoat,
	CONSTRAINT id_contrato_fk PRIMARY KEY (id_contrato),
	CONSTRAINT contratos_id_cliente_pk FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
	CONSTRAINT contratos_id_gerente_pk FOREIGN KEY (id_gerente) REFERENCES Gerente(id_gerente) 
);