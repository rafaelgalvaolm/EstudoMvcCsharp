CREATE TABLE cars (
    id SERIAL PRIMARY KEY,
    make VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    year INT NOT NULL,
    price_per_day DECIMAL(10, 2) NOT NULL
);

CREATE TABLE usuario (
	id int generated always as identity,
	first_name varchar(64) NOT NULL,
	email varchar(128) NOT NULL,
	senha varchar(64) NOT NULL,
	data_cadastro timestamp NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (id),
	CONSTRAINT uq_usuario_email UNIQUE (email),
	CONSTRAINT uq_usuario_apelido UNIQUE (first_name)
);


-- Create the rentals table
CREATE TABLE rentals (
    id SERIAL PRIMARY KEY,
    car_id INT NOT NULL,
    user_id INT NOT NULL,
    rental_start_date DATE NOT NULL,
    rental_end_date DATE NOT NULL,
    rental_cost DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (car_id) REFERENCES cars(id),
    FOREIGN KEY (customer_id) REFERENCES customers(id)
);