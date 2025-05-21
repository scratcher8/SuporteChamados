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
('Erro no login',        'Usuário não consegue autenticar no sistema.',      'Urgente', 'Acesso',     'N1', 'Aberto',   '2025-05-14 10:15:00', NULL, 1),
('Impressora offline',   'Impressora da sala 3 não responde.',                 'Alta',    'Hardware',   'N2', 'Em Andamento',   '2025-05-13 10:15:00', NULL, 2),
('Erro de ortografia',   'Texto no relatório exibe caractere estranho.',       'Média',   'Software',   'N3', 'Pendente',   '2025-05-12 10:15:00', NULL, 3),
('Conexão intermitente', 'Wi-Fi cai a cada 10 minutos no setor financeiro.',   'Alta',    'Rede',       'N4', 'Resolvido',   '2025-05-11 10:15:00', '2025-05-11 11:15:00', 4),
('Solicitação de VPN',   'Preciso de acesso VPN para trabalho remoto.',        'Baixa',   'Acesso',     'N1', 'Fechado', '2025-05-10 10:15:00', '2025-05-10 11:00:00', 5),
('Laptop não liga', 'O computador não inicia após atualização de BIOS.', 'Alta', 'Hardware', 'N2', 'Aberto',      '2025-04-01 09:15:00', NULL, 1),
('Erro 404 no portal', 'Ao acessar o portal interno aparece erro 404.',           'Média', 'Rede',     'N2', 'Em Andamento','2025-03-25 14:30:00', NULL, 2),
('Solicitação de conta', 'Criar conta para novo colaborador.',                   'Baixa',  'Conta',    'N3', 'Resolvido',   '2025-02-10 11:00:00', '2025-02-10 12:00:00', 3),
('Antivírus desatualizado','Verificar atualização do antivírus corporativo.', 'Média', 'Segurança','N2', 'Pendente',    '2025-03-05 16:45:00', NULL, 4),
('Acesso VPN bloqueado',   'VPN não conecta após mudança de senha.',           'Alta',   'Conta',    'N1', 'Aberto',      '2025-04-02 08:20:00', NULL, 5),
('Pedido de mouse',        'Solicitar mouse sem fio para estação de trabalho.','Baixa', 'Solicitações Gerais','N3','Fechado','2025-01-15 10:10:00', '2025-01-15 10:30:00', 6),
('Falha no SSD',           'Disco SSD externo não é reconhecido.',           'Urgente','Hardware', 'N1', 'Em Andamento','2025-04-10 13:00:00', NULL, 7),
('Bug em sistema RH',      'Erro ao calcular férias no módulo de RH.',       'Alta',   'Software', 'N2', 'Aberto',      '2025-03-18 09:50:00', NULL, 8),
('Login Outlook',          'Usuário não consegue logar no Outlook Web.',     'Média',  'Conta',    'N2', 'Resolvido',   '2025-02-28 17:30:00', '2025-02-28 18:00:00', 9),
('Formatação PC',          'Solicitar formatação de máquina lenta.',         'Alta',   'Hardware', 'N2', 'Pendente',    '2025-03-12 15:00:00', NULL, 10),
('Permissão de pasta',     'Conceder acesso à pasta de projetos.',           'Alta',   'Conta',    'N1', 'Resolvido',   '2025-01-22 11:20:00', '2025-01-22 11:45:00', 1),
('Wi-Fi instável',         'Conexão cai frequentemente no 5º andar.',       'Média',  'Rede',     'N2', 'Em Andamento','2025-04-08 10:40:00', NULL, 2),
('Erro no ERP',            'Módulo financeiro trava ao gerar relatório.',    'Urgente','Software', 'N1', 'Aberto',      '2025-03-30 14:55:00', NULL, 3),
('Solicitação de pendrive','Necessita pendrive de 16GB.',                   'Baixa',  'Solicitações Gerais','N3','Fechado','2025-02-05 09:05:00', '2025-02-05 09:30:00', 4),
('Bloqueio de site',       'Site externo bloqueado no firewall.',            'Média',  'Segurança','N2', 'Resolvido',   '2025-01-30 16:15:00', '2025-01-30 16:45:00', 5),
('Impressora sem tinta',   'Impressora 3-D sem filamento.',                 'Baixa',  'Hardware', 'N3', 'Aberto',      '2025-04-12 12:25:00', NULL, 6),
('Atualização Windows',    'Atualização falha na reinicialização.',          'Alta',   'Software', 'N2', 'Pendente',    '2025-03-20 08:30:00', NULL, 7),
('E-mail não envia',       'Outlook retorna erro ao enviar mensagem.',       'Média',  'Conta',    'N2', 'Em Andamento','2025-02-18 14:00:00', NULL, 8),
('Rota de rede ausente',   'Servidor não alcançável via ping.',              'Alta',   'Rede',     'N1', 'Aberto',      '2025-03-28 09:45:00', NULL, 9),
('Cadastro duplicado',     'Usuário aparece duas vezes no AD.',             'Baixa',  'Conta',    'N3', 'Resolvido',   '2025-01-10 10:30:00', '2025-01-10 11:00:00', 10),
('Vazamento de dados',     'Suspeita de vazamento via e-mail externo.',     'Urgente','Segurança','N1', 'Pendente',    '2025-04-15 11:15:00', NULL, 1),
('Solicitação de cadeira', 'Solicitar cadeira ergonômica.',                 'Baixa',  'Solicitações Gerais','N3','Fechado','2025-02-25 13:00:00', '2025-02-25 13:15:00', 2),
('Falha no backup',        'Backup noturno não completou.',                 'Alta',   'Solicitações Gerais','N2','Em Andamento','2025-03-02 06:30:00', NULL, 3),
('Erro ao remover software','Sem permissão para desinstalar app.',          'Média',  'Software', 'N2', 'Resolvido',   '2025-01-29 15:40:00', '2025-01-29 16:00:00', 4),
('VPN desconecta',         'Conexão VPN cai após 30 minutos.',              'Alta',   'Rede',     'N2', 'Pendente',    '2025-04-05 08:55:00', NULL, 5),
('Configurar scanner',     'Instalar driver de scanner MarcaX.',            'Média',  'Hardware', 'N3', 'Aberto',      '2025-02-14 11:45:00', NULL, 6),
('Permissão API',          'Dar acesso à API interna para time dev.',       'Urgente','Conta',    'N1', 'Aberto',      '2025-03-22 10:10:00', NULL, 7),
('Ataque de phishing',     'Usuário clicou em link suspeito.',              'Urgente','Segurança','N1', 'Em Andamento','2025-04-09 12:00:00', NULL, 8),
('Dúvida processo',        'Como solicitar reembolso de despesas?',         'Baixa',  'Solicitações Gerais','N3','Resolvido','2025-01-18 09:20:00', '2025-01-18 09:45:00', 9),
('Outro issue genérico',   'Descrição genérica para caso "Outro".',        'Média',  'Outro',    'N2', 'Fechado',     '2025-02-07 14:35:00', '2025-02-07 15:00:00', 10);

INSERT INTO tblAvaliacao (qualidade, tempoEspera, tempoAtendimento, idTicket) VALUES
(5, 3, 4, 1),
(4, 2, 5, 2),
(3, 4, 3, 3),
(2, 5, 2, 4),
(5, 1, 5, 5);



SELECT * FROM tblUsuario
SELECT * FROM tblTicket

