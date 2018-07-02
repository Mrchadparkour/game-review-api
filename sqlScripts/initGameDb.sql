-- for mysql

USE games;

CREATE TABLE IF NOT EXISTS games (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255),
    score VARCHAR(255),
    oneword VARCHAR(255),
    description LONGTEXT,
    url VARCHAR(255),
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS consoles (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(30),
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS console_game(
    console_id INT NOT NULL,
    game_id INT NOT NULL,
    PRIMARY KEY (console_id, game_id)
);

CREATE TABLE IF NOT EXISTS emptyFields(
   id INT NOT NULL,
   game_id INT, 
   PRIMARY KEY(id),
   FOREIGN KEY (game_id) REFERENCES games(id)
);

CREATE TABLE IF NOT EXISTS failedUrls(
    id INT NOT NULL,
    url VARCHAR(255),
    PRIMARY KEY(id)
);