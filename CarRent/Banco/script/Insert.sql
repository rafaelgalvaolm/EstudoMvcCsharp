-- insert script for carro table
INSERT INTO carro (marca, modelo, ano, preco_dia)
VALUES ('Toyota', 'Rav4', '2020-01-01', 120.50),
('Fiat', 'Doblò', '2018-01-01', 75.00),
('Ferrari', '488 GTB', '2019-01-01', 600.00),
('Porsche', '911 Carrera', '2021-01-01', 550.00);

-- insert script for usuario table
INSERT INTO usuario (nome, sobrenome, email, senha)
VALUES ('João', 'Silva', 'joao.silva@example.com', '123456'),
('Maria', 'Santos', 'maria.santos@example.com', 'abcdef'),
('Pedro', 'Souza', 'pedro.souza@example.com', 'ghijkl'),
('Ana', 'Oliveira', 'ana.oliveira@example.com', 'mnopqr');

-- insert script for aluguel table
INSERT INTO aluguel (id_carro, id_usuario, inicio_aluguel, final_aluguel, custo_total)
VALUES (1, 2, '2023-04-27', '2023-05-01', 482.00),
(2, 3, '2023-04-28', '2023-05-05', 525.00),
(3, 1, '2023-04-29', '2023-05-03', 2400.00),
(4, 4, '2023-04-30', '2023-05-02', 1100.00);