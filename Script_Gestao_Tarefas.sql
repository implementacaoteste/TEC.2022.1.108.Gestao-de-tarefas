
USE [master]
GO
/****** Object:  Database [Gestao_Tarefas]    Script Date: 24/05/2023 17:06:42 ******/
CREATE DATABASE [Gestao_Tarefas]
GO
ALTER DATABASE [Gestao_Tarefas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestao_Tarefas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestao_Tarefas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestao_Tarefas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestao_Tarefas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestao_Tarefas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestao_Tarefas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gestao_Tarefas] SET  MULTI_USER 
GO
ALTER DATABASE [Gestao_Tarefas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestao_Tarefas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestao_Tarefas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestao_Tarefas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gestao_Tarefas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gestao_Tarefas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Gestao_Tarefas] SET QUERY_STORE = OFF
GO
USE [Gestao_Tarefas]
GO
/****** Object:  Table [dbo].[Etapa]    Script Date: 24/05/2023 17:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etapa](
	[IdEtapa] [int] IDENTITY(1,1) NOT NULL,
	[NomeEtapa] [varchar](150) NULL,
	[IdTarefa] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Valor] [int] NULL,
	[Data] [date] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Etapa] PRIMARY KEY CLUSTERED 
(
	[IdEtapa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 24/05/2023 17:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo](
	[IdGrupo] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](150) NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_GrupoDeTarefas] PRIMARY KEY CLUSTERED 
(
	[IdGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListaDeTarefas]    Script Date: 24/05/2023 17:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaDeTarefas](
	[IdLista] [int] IDENTITY(1,1) NOT NULL,
	[NomeLista] [varchar](150) NULL,
	[IdGrupo] [int] NOT NULL,
	[Privacidade] [bit] NULL,
 CONSTRAINT [PK_ListaDeTarefas] PRIMARY KEY CLUSTERED 
(
	[IdLista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListadeTarefas_Usuario]    Script Date: 24/05/2023 17:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListadeTarefas_Usuario](
	[IdListaTarefas] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdPermissao] [int] NOT NULL,
	[Score] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissoes]    Script Date: 24/05/2023 17:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissoes](
	[IdPermissao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](500) NULL,
 CONSTRAINT [PK_Permissoes] PRIMARY KEY CLUSTERED 
(
	[IdPermissao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarefa]    Script Date: 24/05/2023 17:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarefa](
	[IdTarefa] [int] IDENTITY(1,1) NOT NULL,
	[NomeTarefa] [varchar](150) NULL,
	[IdListaDeTarefas] [int] NOT NULL,
 CONSTRAINT [PK_Tarefa] PRIMARY KEY CLUSTERED 
(
	[IdTarefa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/05/2023 17:06:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NULL,
	[Email] [varchar](200) NULL,
	[Senha] [varchar](32) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ListaDeTarefas] ADD  CONSTRAINT [DF_ListaDeTarefas_Privacidade]  DEFAULT ((0)) FOR [Privacidade]
GO
ALTER TABLE [dbo].[ListadeTarefas_Usuario] ADD  CONSTRAINT [DF_ListadeTarefas_Usuario_Score]  DEFAULT ((0)) FOR [Score]
GO
ALTER TABLE [dbo].[Etapa]  WITH CHECK ADD  CONSTRAINT [FK_Etapa_Tarefa] FOREIGN KEY([IdTarefa])
REFERENCES [dbo].[Tarefa] ([IdTarefa])
GO
ALTER TABLE [dbo].[Etapa] CHECK CONSTRAINT [FK_Etapa_Tarefa]
GO
ALTER TABLE [dbo].[Etapa]  WITH CHECK ADD  CONSTRAINT [FK_Etapa_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Etapa] CHECK CONSTRAINT [FK_Etapa_Usuario]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_Grupo_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_Grupo_Usuario]
GO
ALTER TABLE [dbo].[ListaDeTarefas]  WITH CHECK ADD  CONSTRAINT [FK_ListaDeTarefas_Grupo] FOREIGN KEY([IdGrupo])
REFERENCES [dbo].[Grupo] ([IdGrupo])
GO
ALTER TABLE [dbo].[ListaDeTarefas] CHECK CONSTRAINT [FK_ListaDeTarefas_Grupo]
GO
ALTER TABLE [dbo].[ListadeTarefas_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_ListadeTarefas_Usuario_ListaDeTarefas] FOREIGN KEY([IdListaTarefas])
REFERENCES [dbo].[ListaDeTarefas] ([IdLista])
GO
ALTER TABLE [dbo].[ListadeTarefas_Usuario] CHECK CONSTRAINT [FK_ListadeTarefas_Usuario_ListaDeTarefas]
GO
ALTER TABLE [dbo].[ListadeTarefas_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_ListadeTarefas_Usuario_Permissoes] FOREIGN KEY([IdPermissao])
REFERENCES [dbo].[Permissoes] ([IdPermissao])
GO
ALTER TABLE [dbo].[ListadeTarefas_Usuario] CHECK CONSTRAINT [FK_ListadeTarefas_Usuario_Permissoes]
GO
ALTER TABLE [dbo].[ListadeTarefas_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_ListadeTarefas_Usuario_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ListadeTarefas_Usuario] CHECK CONSTRAINT [FK_ListadeTarefas_Usuario_Usuario]
GO
ALTER TABLE [dbo].[Tarefa]  WITH CHECK ADD  CONSTRAINT [FK_Tarefa_ListaDeTarefas] FOREIGN KEY([IdListaDeTarefas])
REFERENCES [dbo].[ListaDeTarefas] ([IdLista])
GO
ALTER TABLE [dbo].[Tarefa] CHECK CONSTRAINT [FK_Tarefa_ListaDeTarefas]
GO
USE [master]
GO
ALTER DATABASE [Gestao_Tarefas] SET  READ_WRITE 
GO
