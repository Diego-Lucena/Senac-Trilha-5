-- Inserindo novo colaborador
INSERT INTO BRH.COLABORADOR
(MATRICULA, CPF, NOME, SALARIO, DEPARTAMENTO, CEP, LOGRADOURO, COMPLEMENTO_ENDERECO)
VALUES ('G789', '444.555.666-77', 'Fulano', 16000.00, 'GTI','02222-090','Rua do fulano','CASA');

-- Inserido  projeto
INSERT INTO BRH.PROJETO
(ID, NOME, RESPONSAVEL, INICIO, FIM)
VALUES (5, 'BI', 'D999','08/05/2024','22/12/2024');

-- Inserido  papel
INSERT INTO BRH.PAPEL
(ID, NOME)
VALUES (8, 'Especialista de Negócios');

-- Inserido  celular
INSERT INTO BRH.TELEFONE_COLABORADOR
(NUMERO, COLABORADOR, TIPO)
VALUES ('(61) 9 9999-9999;','G789','C'); -- Celular

-- Inserido  residencial 
INSERT INTO BRH.TELEFONE_COLABORADOR
(NUMERO, COLABORADOR, TIPO)
VALUES ('(61) 3030-4040','G789','C'); -- Celular

-- Inserido  email
INSERT INTO BRH.Email_COLABORADOR
(EMAIL, COLABORADOR, TIPO)
VALUES ('fulano@email.com','G789','P'); -- Pessoal

-- Inserido  email trabalho 
INSERT INTO BRH.EMAIL_COLABORADOR
(EMAIL, COLABORADOR, TIPO)
VALUES ('fulano.tal@brh.com','G789','T'); -- Trabalho

-- Inserido  dependente filho
INSERT INTO BRH.DEPENDENTE
(CPF, NOME, DATA_NASCIMENTO, PARENTESCO, COLABORADOR)
VALUES ('999.999.999.99', 'Filha Beltrana de Tal', '07/04/2025', 'Filho(a)', 'G789');

-- Inserido  esposa
INSERT INTO BRH.DEPENDENTE
(CPF, NOME, DATA_NASCIMENTO, PARENTESCO, COLABORADOR)
VALUES ('999.999.999.98', 'Esposa Cicrana de Tal', '20/07/1993', 'CÃ´njuge', 'G789');
