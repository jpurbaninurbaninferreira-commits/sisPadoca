CREATE TABLE [Produtos] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nome] nvarchar(100) NOT NULL,
	[categoria] nvarchar(50) NOT NULL,
	[preco] decimal(10,2) NOT NULL,
	[quantidade_estoque] int NOT NULL,
	[data_validade] date,
	[data_fabricacao] date,
	[codigo_barras] nvarchar(20) UNIQUE,
	[unidade_medida] nvarchar(10) NOT NULL,
	PRIMARY KEY ([id])
);
CREATE TABLE [Funcionarios] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nome] nvarchar(100) NOT NULL,
	[cpf] nvarchar(14) NOT NULL UNIQUE,
	[cargo] nvarchar(50) NOT NULL,
	[telefone] nvarchar(20) NOT NULL,
	[data_admissao] date NOT NULL,
	[salario] decimal(10,2) NOT NULL,
	[email] nvarchar(100) UNIQUE,
	[rg] nvarchar(12),
	[endereco] nvarchar(150),
	[turno] nvarchar(20) NOT NULL,
	[data_demissao] date,
	PRIMARY KEY ([id])
);
CREATE TABLE [Clientes] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nome] nvarchar(100) NOT NULL,
	[cpf] nvarchar(14) UNIQUE,
	[telefone] nvarchar(20) NOT NULL,
	[email] nvarchar(100) UNIQUE,
	[endereco] nvarchar(150),
	[cidade] nvarchar(60),
	[bairro] nvarchar(60),
	[cep] nvarchar(9),
	[data_nascimento] date,
	[data_cadastro] date NOT NULL,
	PRIMARY KEY ([id])
);
CREATE TABLE [Vendas] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[data_vendas] datetime NOT NULL,
	[quantidade] int NOT NULL,
	[valor_total] decimal(10,2) NOT NULL,
	[clientes_id] int NOT NULL,
	[funcionarios_id] int NOT NULL,
	[produtos_id] int NOT NULL,
	PRIMARY KEY ([id])
);
ALTER TABLE [Vendas] ADD CONSTRAINT [Vendas_fk4] FOREIGN KEY ([clientes_id]) REFERENCES [Clientes]([id]);
ALTER TABLE [Vendas] ADD CONSTRAINT [Vendas_fk5] FOREIGN KEY ([funcionarios_id]) REFERENCES [Funcionarios]([id]);
ALTER TABLE [Vendas] ADD CONSTRAINT [Vendas_fk6] FOREIGN KEY ([produtos_id]) REFERENCES [Produtos]([id]);