CREATE DATABASE db_carros;

USE db_carros;

CREATE TABLE Marca (
  id_marca INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(255) 
);

CREATE TABLE Modelo (
  id_modelo INT PRIMARY KEY AUTO_INCREMENT,
  descricao VARCHAR(255),
  eixo VARCHAR(255),
  peso VARCHAR(255),
  passageiros VARCHAR(255),
  cavalo VARCHAR(255),
  cilindradas VARCHAR(255),
  fk_marca_id INT NOT NULL,
  FOREIGN KEY (fk_marca_id) REFERENCES Marca(id_marca)
);