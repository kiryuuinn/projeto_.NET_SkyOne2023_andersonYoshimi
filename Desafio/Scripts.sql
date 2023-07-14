SELECT * FROM Alunos;

-- Teste 06
CREATE TABLE Alunos(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nome varchar(200) NOT NULL,
	ano int NOT NULL,
	nota1 decimal(8, 2),
	nota2 decimal(8, 2)
)
GO

-- Teste 07
INSERT INTO Alunos(nome, ano, nota1, nota2) VALUES ('Joao', 2022, 5, 10);
INSERT INTO Alunos(nome, ano, nota1, nota2) VALUES ('Joao', 2023, 7, 5);
INSERT INTO Alunos(nome, ano, nota1, nota2) VALUES ('Carlos', 2022, 3, 7);
INSERT INTO Alunos(nome, ano, nota1, nota2) VALUES ('Joao', 2022, 2, 10);
INSERT INTO Alunos(nome, ano, nota1, nota2) VALUES ('Vinicius', 2022, 4.5, 6);
INSERT INTO Alunos(nome, ano, nota1, nota2) VALUES ('Vinicius', 2022, 3.1, 7.7);

-- Teste 08
SELECT	nome AS 'Nome do Aluno',
		nota1 AS 'Nota do Primeiro Semestre', 	
		nota2 AS 'Nota do Segundo Semestre', 	
		(nota1 + nota2) / 2 AS 'Media Anual', 	
		ano AS 'Ano', 	
		CASE WHEN ((nota1 + nota2) / 2) < 6.5 THEN 'Reprovado' ELSE 'Aprovado' END AS 'Status'  
FROM Alunos;

-- Teste 09
SELECT	nome AS 'Nome do Aluno',
		nota1 AS 'Nota do Primeiro Semestre', 	
		nota2 AS 'Nota do Segundo Semestre', 	
		(nota1 + nota2) / 2 AS 'Media Anual', 	
		ano AS 'Ano', 	
		CASE WHEN ((nota1 + nota2) / 2) < 6.5 THEN 'Reprovado' ELSE 'Aprovado' END AS 'Status'  
FROM Alunos
WHERE ((nota1 + nota2) / 2) > 6
;



