-- Insert data into 'car' table
INSERT INTO car (make, model, year, price_per_day)
VALUES 
    ('Toyota', 'RAV4', '2020-01-01', 65.00), -- SUV
    ('Ford', 'Transit Connect', '2021-01-01', 50.00), -- Utilitarian
    ('Chevrolet', 'Corvette', '2019-01-01', 200.00), -- Performance
    ('Porsche', '911', '2022-01-01', 250.00), -- Sports
    ('Jeep', 'Wrangler', '2021-01-01', 80.00), -- SUV
    ('Volkswagen', 'Golf', '2020-01-01', 55.00), -- Performance
    ('Ford', 'F-150', '2021-01-01', 95.00), -- Utilitarian
    ('BMW', 'M4', '2018-01-01', 300.00), -- Sports
    ('Toyota', 'Prius', '2022-01-01', 45.00), -- Utilitarian
    ('Audi', 'RS7', '2020-01-01', 275.00); -- Performance

-- Insert data into 'user' table
INSERT INTO user (first_name, last_name, email, password)
VALUES 
    ('John', 'Doe', 'johndoe@email.com', 'password123'),
    ('Jane', 'Doe', 'janedoe@email.com', 'password456'),
    ('Bob', 'Smith', 'bobsmith@email.com', 'password789');

-- Insert data into 'rental' table
INSERT INTO rental (car_id, user_id, rental_start_date, rental_end_date, rental_cost)
VALUES
    (1, 1, '2023-05-01', '2023-05-05', 260.00),
    (2, 1, '2023-05-03', '2023-05-06', 150.00),
    (3, 2, '2023-05-01', '2023-05-04', 600.00),
    (4, 2, '2023-05-01', '2023-05-02', 500.00),
    (5, 3, '2023-05-02', '2023-05-05', 240.00),
    (6, 3, '2023-05-03', '2023-05-07', 220.00),
    (7, 1, '2023-05-05', '2023-05-08', 285.00),
    (8, 2, '2023-05-04', '2023-05-06', 550.00),
    (9, 3, '2023-05-02', '2023-05-05', 135.00),
    (10, 1, '2023-05-06', '2023-05-10', 1100.00);