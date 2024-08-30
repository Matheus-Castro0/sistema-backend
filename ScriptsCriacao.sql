--Criar o banco
CREATE DATABASE programacao_do_zero;

--Usar o banco
USE programacao_do_zero;

--Criar tabela usuário
CREATE TABLE usuario (
	id INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	sobrenome VARCHAR(150) NOT NULL,
	telefone VARCHAR(15) NOT NULL,
	email VARCHAR(50) NOT NULL,
	genero VARCHAR(20) NOT NULL,
	senha VARCHAR(30) NOT NULL,
	PRIMARY KEY(id)
);

--Criar tabela endereço
CREATE TABLE endereco(
	id INT NOT NULL AUTO_INCREMENT,
	numero VARCHAR(250) NOT NULL,
	rua VARCHAR(30) NOT NULL,
	bairro VARCHAR(150) NOT NULL,
	cidade VARCHAR(250) NOT NULL,
	complemento VARCHAR(150) NULL,
	cep VARCHAR(9) NOT NULL,
	estado VARCHAR(2),
	PRIMARY KEY(id)
);

--Alterar tabela endereço
ALTER TABLE endereco ADD usuario_id INT NOT NULL;

--Adicionar chave estrangeira
ALTER TABLE endereco ADD CONSTRAINT FK_usuario FOREIGN KEY (usuario_id) REFERENCES usuario(id);

--Inserir usuário
INSERT INTO usuario
(nome, sobrenome, telefone, email, genero, senha) 
VALUES 
('Matheus', 'Castro', '(31) 98977-2110', 'castrodepaulamatheus2@gmail.com', 'masculino', '123')

--Selecionar todos os usuários
SELECT * FROM usuario;

--Selecionar um usuário específico
SELECT * FROM usuario WHERE id='1';

SELECT * FROM usuario WHERE telefone='31989772110';

--Alterar usuário
UPDATE usuario SET email='matheuscastro@gmail.com' WHERE id='1';

--Excluir usuário
DELETE FROM usuario WHERE id='3';
