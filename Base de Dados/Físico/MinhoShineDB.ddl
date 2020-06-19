CREATE TABLE Cliente (IdCliente int IDENTITY NOT NULL, Nome varchar(180) NOT NULL, Email varchar(100) NOT NULL, Morada varchar(200) NOT NULL, Password varchar(16) NOT NULL, Contacto varchar(9) NOT NULL, PRIMARY KEY (IdCliente));
CREATE TABLE Recomendacao (IdRecomendacao int IDENTITY NOT NULL, Email varchar(80) NOT NULL, Mensagem varchar(255) NOT NULL, IdCliente int NOT NULL, PRIMARY KEY (IdRecomendacao));
CREATE TABLE Funcionario (IdFuncionario int IDENTITY NOT NULL, Nome varchar(50) NOT NULL, Email varchar(80) NOT NULL, Password varchar(16) NOT NULL, Contacto varchar(9) NOT NULL, PRIMARY KEY (IdFuncionario));
CREATE TABLE Servico (IdServico int IDENTITY NOT NULL, Data varchar(10) NOT NULL, Morada varchar(80) NOT NULL, Duracao float(5) NOT NULL, Preco float(6) NOT NULL, Descricao varchar(255) NOT NULL, IdCliente int NOT NULL, IdFuncionario int NOT NULL, PRIMARY KEY (IdServico));
ALTER TABLE Recomendacao ADD CONSTRAINT FKRecomendac466557 FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente);
ALTER TABLE Servico ADD CONSTRAINT FKServico965239 FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente);
ALTER TABLE Servico ADD CONSTRAINT FKServico777799 FOREIGN KEY (IdFuncionario) REFERENCES Funcionario (IdFuncionario);
