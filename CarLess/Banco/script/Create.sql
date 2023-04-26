CREATE TABLE car (
	id int generated always as identity,
    make VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    year DATE NOT NULL,
    price_per_day DECIMAL(10, 2) NOT NULL,
    CONSTRAINT pk_car PRIMARY KEY (id)

);

CREATE TABLE user (
	id int generated always as identity,
	first_name varchar(50) NOT NULL,
    last_name varchar(70) NOT NULL,
	email varchar(128) NOT NULL,
	password varchar(64) NOT NULL,
	CONSTRAINT pk_user PRIMARY KEY (id),
	CONSTRAINT uq_user_email UNIQUE (email)
);


CREATE TABLE rental (
    id int generated always as identity,
    car_id INT NOT NULL,
    user_id INT NOT NULL,
    rental_start_date DATE NOT NULL,
    rental_end_date DATE NOT NULL,
    rental_cost DECIMAL(10, 2) NOT NULL,
    CONSTRAINT pk_rentals PRIMARY KEY (id),
    FOREIGN KEY (car_id) REFERENCES car(id),
    FOREIGN KEY (user_id) REFERENCES user(id)
);