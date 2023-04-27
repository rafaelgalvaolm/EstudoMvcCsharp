CREATE TABLE carro (
	id int generated always as identity,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    ano DATE NOT NULL,
    preco_dia DECIMAL(10, 2) NOT NULL,
    CONSTRAINT pk_carro PRIMARY KEY (id)

);

CREATE TABLE usuario (
	id int generated always as identity,
	nome varchar(50) NOT NULL,
    sobrenome varchar(70) NOT NULL,
	email varchar(128) NOT NULL,
	senha varchar(64) NOT NULL,
    is_admin BOOLEAN NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email)
);


CREATE TABLE aluguel (
    id int generated always as identity,
    id_carro INT NOT NULL,
    id_usuario INT NOT NULL,
    inicio_aluguel DATE NOT NULL,
    final_aluguel DATE NOT NULL,
    custo_total DECIMAL(10, 2) NOT NULL,
    finalizado BOOLEAN NOT NULL,
    CONSTRAINT pk_aluguel PRIMARY KEY (id),
    FOREIGN KEY (id_carro) REFERENCES carro(id),
    FOREIGN KEY (id_usuario) REFERENCES usuario(id)
);