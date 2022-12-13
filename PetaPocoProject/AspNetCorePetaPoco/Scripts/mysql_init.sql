CREATE TABLE IF NOT EXISTS Funcionarios (

	id				bigint AUTO_INCREMENT NOT NULL,
	nome			varchar(500) NOT NULL,
	idade   		int NOT NULL,
	PRIMARY KEY (id)
) ENGINE=INNODB;
