CREATE DATABASE dbSuporteChamados
ON PRIMARY
(
	NAME = dbSuporteChamados,
	FILENAME = 'C:\BD\dbSuporteChamados.MDF',
	SIZE = 10MB,
	MAXSIZE = 30MB,
	FILEGROWTH = 10%
);

GO
USE dbSuporteChamados;
GO

CREATE TABLE tblUsuario
(
	idUsuario INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	loginUsuario VARCHAR(200) UNIQUE,
	senha VARCHAR(100)
);

CREATE TABLE tblTicket
(
	idTicket INT PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(200),
	descricao VARCHAR(500),
	prioridade VARCHAR(50),
	categoria VARCHAR(50),
	nivel VARCHAR(50),
	statusTicket VARCHAR(50),
	dataTicket DATETIME,
	dataFechamento DATETIME NULL,
	idSolicitante INT NOT NULL
);

ALTER TABLE tblTicket ADD CONSTRAINT FK_Ticket_Usuario FOREIGN KEY(idSolicitante) REFERENCES tblUsuario(idUsuario);

CREATE TABLE tblAvaliacao
(
	idAvaliacao INT PRIMARY KEY IDENTITY(1,1),
	qualidade INT,
	tempoEspera INT,
	tempoAtendimento INT,
	idTicket INT NOT NULL
);

ALTER TABLE tblAvaliacao ADD CONSTRAINT FK_Avaliacao_Ticket FOREIGN KEY(idTicket) REFERENCES tblTicket(idTicket);



INSERT INTO tblUsuario (nome, loginUsuario, senha) VALUES
('Alice Silva', 'alice', '1234'),
('Bruno Costa', 'bruno', '2025'),
('Carla Pereira', 'admin', '1234'),
('Daniel Souza', 'daniel', 'Dani456'),
('Elaine Ramos', 'elaine', 'Elaine789'),
('Felipe Oliveira', 'felipe', 'Felipe012'),
('Gabriela Mendes', 'gabriela', 'Gabi345'),
('Henrique Alves', 'henrique', 'Henrique'),
('Isabela Ferreira', 'isabela','Isa'),
('Joaquim Rocha', 'joaquim', '3456');

INSERT INTO tblTicket (titulo, descricao, prioridade, categoria, nivel, statusTicket, dataTicket, dataFechamento, idSolicitante) VALUES
('Erro no login',        'Usu�rio n�o consegue autenticar no sistema.',      'Urgente', 'Acesso',     'N1', 'Aberto',   '2025-05-14 10:15:00', NULL, 1),
('Impressora offline',   'Impressora da sala 3 n�o responde.',                 'Alta',    'Hardware',   'N2', 'Em Andamento',   '2025-05-13 10:15:00', NULL, 2),
('Erro de ortografia',   'Texto no relat�rio exibe caractere estranho.',       'M�dia',   'Software',   'N3', 'Pendente',   '2025-05-12 10:15:00', NULL, 3),
('Conex�o intermitente', 'Wi-Fi cai a cada 10 minutos no setor financeiro.',   'Alta',    'Rede',       'N4', 'Resolvido',   '2025-05-11 10:15:00', '2025-05-11 11:15:00', 4),
('Solicita��o de VPN',   'Preciso de acesso VPN para trabalho remoto.',        'Baixa',   'Acesso',     'N1', 'Fechado', '2025-05-10 10:15:00', '2025-05-10 11:00:00', 5),
('Laptop n�o liga', 'O computador n�o inicia ap�s atualiza��o de BIOS.', 'Alta', 'Hardware', 'N2', 'Aberto',      '2025-04-01 09:15:00', NULL, 1),
('Erro 404 no portal', 'Ao acessar o portal interno aparece erro 404.',           'M�dia', 'Rede',     'N2', 'Em Andamento','2025-03-25 14:30:00', NULL, 2),
('Solicita��o de conta', 'Criar conta para novo colaborador.',                   'Baixa',  'Conta',    'N3', 'Resolvido',   '2025-02-10 11:00:00', '2025-02-10 12:00:00', 3),
('Antiv�rus desatualizado','Verificar atualiza��o do antiv�rus corporativo.', 'M�dia', 'Seguran�a','N2', 'Pendente',    '2025-03-05 16:45:00', NULL, 4),
('Acesso VPN bloqueado',   'VPN n�o conecta ap�s mudan�a de senha.',           'Alta',   'Conta',    'N1', 'Aberto',      '2025-04-02 08:20:00', NULL, 5),
('Pedido de mouse',        'Solicitar mouse sem fio para esta��o de trabalho.','Baixa', 'Solicita��es Gerais','N3','Fechado','2025-01-15 10:10:00', '2025-01-15 10:30:00', 6),
('Falha no SSD',           'Disco SSD externo n�o � reconhecido.',           'Urgente','Hardware', 'N1', 'Em Andamento','2025-04-10 13:00:00', NULL, 7),
('Bug em sistema RH',      'Erro ao calcular f�rias no m�dulo de RH.',       'Alta',   'Software', 'N2', 'Aberto',      '2025-03-18 09:50:00', NULL, 8),
('Login Outlook',          'Usu�rio n�o consegue logar no Outlook Web.',     'M�dia',  'Conta',    'N2', 'Resolvido',   '2025-02-28 17:30:00', '2025-02-28 18:00:00', 9),
('Formata��o PC',          'Solicitar formata��o de m�quina lenta.',         'Alta',   'Hardware', 'N2', 'Pendente',    '2025-03-12 15:00:00', NULL, 10),
('Permiss�o de pasta',     'Conceder acesso � pasta de projetos.',           'Alta',   'Conta',    'N1', 'Resolvido',   '2025-01-22 11:20:00', '2025-01-22 11:45:00', 1),
('Wi-Fi inst�vel',         'Conex�o cai frequentemente no 5� andar.',       'M�dia',  'Rede',     'N2', 'Em Andamento','2025-04-08 10:40:00', NULL, 2),
('Erro no ERP',            'M�dulo financeiro trava ao gerar relat�rio.',    'Urgente','Software', 'N1', 'Aberto',      '2025-03-30 14:55:00', NULL, 3),
('Solicita��o de pendrive','Necessita pendrive de 16GB.',                   'Baixa',  'Solicita��es Gerais','N3','Fechado','2025-02-05 09:05:00', '2025-02-05 09:30:00', 4),
('Bloqueio de site',       'Site externo bloqueado no firewall.',            'M�dia',  'Seguran�a','N2', 'Resolvido',   '2025-01-30 16:15:00', '2025-01-30 16:45:00', 5),
('Impressora sem tinta',   'Impressora 3-D sem filamento.',                 'Baixa',  'Hardware', 'N3', 'Aberto',      '2025-04-12 12:25:00', NULL, 6),
('Atualiza��o Windows',    'Atualiza��o falha na reinicializa��o.',          'Alta',   'Software', 'N2', 'Pendente',    '2025-03-20 08:30:00', NULL, 7),
('E-mail n�o envia',       'Outlook retorna erro ao enviar mensagem.',       'M�dia',  'Conta',    'N2', 'Em Andamento','2025-02-18 14:00:00', NULL, 8),
('Rota de rede ausente',   'Servidor n�o alcan��vel via ping.',              'Alta',   'Rede',     'N1', 'Aberto',      '2025-03-28 09:45:00', NULL, 9),
('Cadastro duplicado',     'Usu�rio aparece duas vezes no AD.',             'Baixa',  'Conta',    'N3', 'Resolvido',   '2025-01-10 10:30:00', '2025-01-10 11:00:00', 10),
('Vazamento de dados',     'Suspeita de vazamento via e-mail externo.',     'Urgente','Seguran�a','N1', 'Pendente',    '2025-04-15 11:15:00', NULL, 1),
('Solicita��o de cadeira', 'Solicitar cadeira ergon�mica.',                 'Baixa',  'Solicita��es Gerais','N3','Fechado','2025-02-25 13:00:00', '2025-02-25 13:15:00', 2),
('Falha no backup',        'Backup noturno n�o completou.',                 'Alta',   'Solicita��es Gerais','N2','Em Andamento','2025-03-02 06:30:00', NULL, 3),
('Erro ao remover software','Sem permiss�o para desinstalar app.',          'M�dia',  'Software', 'N2', 'Resolvido',   '2025-01-29 15:40:00', '2025-01-29 16:00:00', 4),
('VPN desconecta',         'Conex�o VPN cai ap�s 30 minutos.',              'Alta',   'Rede',     'N2', 'Pendente',    '2025-04-05 08:55:00', NULL, 5),
('Configurar scanner',     'Instalar driver de scanner MarcaX.',            'M�dia',  'Hardware', 'N3', 'Aberto',      '2025-02-14 11:45:00', NULL, 6),
('Permiss�o API',          'Dar acesso � API interna para time dev.',       'Urgente','Conta',    'N1', 'Aberto',      '2025-03-22 10:10:00', NULL, 7),
('Ataque de phishing',     'Usu�rio clicou em link suspeito.',              'Urgente','Seguran�a','N1', 'Em Andamento','2025-04-09 12:00:00', NULL, 8),
('D�vida processo',        'Como solicitar reembolso de despesas?',         'Baixa',  'Solicita��es Gerais','N3','Resolvido','2025-01-18 09:20:00', '2025-01-18 09:45:00', 9),
('Outro issue gen�rico',   'Descri��o gen�rica para caso "Outro".',        'M�dia',  'Outro',    'N2', 'Fechado',     '2025-02-07 14:35:00', '2025-02-07 15:00:00', 10);

INSERT INTO tblAvaliacao (qualidade, tempoEspera, tempoAtendimento, idTicket) VALUES
(5, 3, 4, 1),
(4, 2, 5, 2),
(3, 4, 3, 3),
(2, 5, 2, 4),
(5, 1, 5, 5);



SELECT * FROM tblUsuario
SELECT * FROM tblTicket

