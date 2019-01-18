namespace Faculdade.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Faculdade.Model;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Faculdade.Model.FaculdadeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Faculdade.Model.FaculdadeDBContext context)
        {
            // TURMAS //
            var turmas = new List<Turma>
            {
                new Model.Turma { nomeTurma = "Turma 1001", numeroMaxAlunos = 20 },
                new Model.Turma { nomeTurma = "Turma 1002", numeroMaxAlunos = 20 },
                new Model.Turma { nomeTurma = "Turma 1003", numeroMaxAlunos = 20 }
            };
            turmas.ForEach(s => context.Turma.AddOrUpdate(p => p.idTurma, s));
            context.SaveChanges();

            // ALUNOS //
            var alunos = new List<Aluno>
            {
                new Model.Aluno { matricula="2019010001", nome="Marcos Antonio", idTurma = 1 },
                new Model.Aluno { matricula="2019010002", nome="Edson Oliveira", idTurma = 1 },
                new Model.Aluno { matricula="2019010003", nome="Jefferson Praxedes", idTurma = 1 },
                new Model.Aluno { matricula="2019010004", nome="Irta Oliveira", idTurma = 1 },
                new Model.Aluno { matricula="2019010005", nome="Nathalia Azevedo", idTurma = 1 },
                new Model.Aluno { matricula="2019010006", nome="Astrogesio de Ataide", idTurma = 1 },
                new Model.Aluno { matricula="2019010007", nome="Fernando Silva", idTurma = 1 },
                new Model.Aluno { matricula="2019010008", nome="Marcelo Abrantes", idTurma = 1 },
                new Model.Aluno { matricula="2019010009", nome="Mauro Guedes", idTurma = 1 },
                new Model.Aluno { matricula="2019010010", nome="Francisco Bicalho", idTurma = 1 },
                new Model.Aluno { matricula="2019010011", nome="Fernando Magalhaes", idTurma = 1 },
                new Model.Aluno { matricula="2019010012", nome="Fatima Ferreira", idTurma = 1 },
                new Model.Aluno { matricula="2019010013", nome="Ana Claudia", idTurma = 1 },
                new Model.Aluno { matricula="2019010014", nome="Eliane Aparecida", idTurma = 1 },
                new Model.Aluno { matricula="2019010015", nome="Ivone Maria", idTurma = 1 },
                new Model.Aluno { matricula="2019010016", nome="Leonaaro Cammpelo", idTurma = 1 },
                new Model.Aluno { matricula="2019010017", nome="Marcos de Almeida", idTurma = 1 },
                new Model.Aluno { matricula="2019010018", nome="Joana Guimaraes", idTurma = 1 },
                new Model.Aluno { matricula="2019010019", nome="Jose Marques", idTurma = 1 },
                new Model.Aluno { matricula="2019010020", nome="Hugo Bastos", idTurma = 1 },

                new Model.Aluno { matricula="2019010021", nome="Alessandro Costa", idTurma = 2 },
                new Model.Aluno { matricula="2019010022", nome="Erika Machado", idTurma = 2 },
                new Model.Aluno { matricula="2019010023", nome="Genilson Teixeira", idTurma = 2 },
                new Model.Aluno { matricula="2019010024", nome="Genildo Bezerra", idTurma = 2 },
                new Model.Aluno { matricula="2019010025", nome="Marcos Antonio", idTurma = 2 },
                new Model.Aluno { matricula="2019010026", nome="Fernando de Paula", idTurma = 2 },
                new Model.Aluno { matricula="2019010027", nome="Ferdinando Silva", idTurma = 2 },
                new Model.Aluno { matricula="2019010028", nome="Aurelio Ramos", idTurma = 2 },
                new Model.Aluno { matricula="2019010029", nome="Brenda Fioruzzi", idTurma = 2 },
                new Model.Aluno { matricula="2019010030", nome="Florencio Abreu", idTurma = 2 },
                new Model.Aluno { matricula="2019010031", nome="Josenildo Campelo", idTurma = 2 },
                new Model.Aluno { matricula="2019010032", nome="Juliana Mendes", idTurma = 2 },
                new Model.Aluno { matricula="2019010033", nome="João Paulo", idTurma = 2 },
                new Model.Aluno { matricula="2019010034", nome="João Pedro", idTurma = 2 },
                new Model.Aluno { matricula="2019010035", nome="Fellipe de Mello", idTurma = 2 },
                new Model.Aluno { matricula="2019010036", nome="Lais Silva", idTurma = 2 },
                new Model.Aluno { matricula="2019010037", nome="Mariana Barreto", idTurma = 2 },
                new Model.Aluno { matricula="2019010038", nome="Karina Barroso", idTurma = 2 },
                new Model.Aluno { matricula="2019010039", nome="Luiza Alves", idTurma = 2 },
                new Model.Aluno { matricula="2019010040", nome="Celso Borges", idTurma = 2 },

                new Model.Aluno { matricula="2019010055", nome="Bruno Fonseca", idTurma = 3 },
                new Model.Aluno { matricula="2019010041", nome="Rafaela Siqueira", idTurma = 3 },
                new Model.Aluno { matricula="2019010042", nome="Luiza Soares", idTurma = 3 },
                new Model.Aluno { matricula="2019010043", nome="Beatriz Miranda", idTurma = 3 },
                new Model.Aluno { matricula="2019010044", nome="Gustavo Ferreira", idTurma = 3 },
                new Model.Aluno { matricula="2019010045", nome="Daniel Affonso", idTurma = 3 },
                new Model.Aluno { matricula="2019010046", nome="Karoline Mmchado", idTurma = 3 },
                new Model.Aluno { matricula="2019010047", nome="Vitor Monteiro", idTurma = 3 },
                new Model.Aluno { matricula="2019010048", nome="Helena Dias", idTurma = 3 },
                new Model.Aluno { matricula="2019010049", nome="Diogo Dinniz", idTurma = 3 },
                new Model.Aluno { matricula="2019010050", nome="Vinicius Araujo", idTurma = 3 },
                new Model.Aluno { matricula="2019010051", nome="Theodoro Fonseca", idTurma = 3 },
                new Model.Aluno { matricula="2019010052", nome="Laura Cavalcante", idTurma = 3 },
                new Model.Aluno { matricula="2019010053", nome="Borges Pinheiro", idTurma = 3 },
                new Model.Aluno { matricula="2019010054", nome="Miguel Guimaraes", idTurma = 3 },
                new Model.Aluno { matricula="2019010056", nome="Maarcela da Rocha", idTurma = 3 },
                new Model.Aluno { matricula="2019010057", nome="Arthur Ribeiro", idTurma = 3 },
                new Model.Aluno { matricula="2019010058", nome="Ricardo Mello", idTurma = 3 },
                new Model.Aluno { matricula="2019010059", nome="Adriaano Barreto", idTurma = 3 },
                new Model.Aluno { matricula="2019010060", nome="Rafael Carvalho", idTurma = 3 }

            };
            alunos.ForEach(s => context.Aluno.AddOrUpdate(p => p.idAluno, s));
            context.SaveChanges();

            // DISCIPLINAS //
            var disciplinas = new List<Disciplina>
            {
                new Model.Disciplina { NomeDisciplina="Matematica"}
            };
            disciplinas.ForEach(s => context.Disciplina.AddOrUpdate(p => p.IdDisciplina, s));
            context.SaveChanges();

            // PROVAS //
            var provas = new List<Prova>
            {
                new Model.Prova { idDisciplina = 1, nomeProva="Prova 1", numeroProva=1, peso=1 },
                new Model.Prova { idDisciplina = 1, nomeProva="Prova 2", numeroProva=2, peso=1.2 },
                new Model.Prova { idDisciplina = 1, nomeProva="Prova 3", numeroProva=3, peso=1.4 }
            };
            provas.ForEach(s => context.Prova.AddOrUpdate(p => p.idProva, s));
            context.SaveChanges();

            // PROVAS DOS ALUNOS //

            var provasAlunos = new List<ProvaAluno>
            {
                new Model.ProvaAluno { idAluno = 1, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 1, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 1, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 2, idProva = 1, notaAluno = 7.5 },
                new Model.ProvaAluno { idAluno = 2, idProva = 2, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 2, idProva = 3, notaAluno = 9.5 },

                new Model.ProvaAluno { idAluno = 3, idProva = 1, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 3, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 3, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 4, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 4, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 4, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 5, idProva = 1, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 5, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 5, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 6, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 6, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 6, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 7, idProva = 1, notaAluno = 5.5 },
                new Model.ProvaAluno { idAluno = 7, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 7, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 8, idProva = 1, notaAluno = 2.5 },
                new Model.ProvaAluno { idAluno = 8, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 8, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 9, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 9, idProva = 2, notaAluno = 2.5 },
                new Model.ProvaAluno { idAluno = 9, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 10, idProva = 1, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 10, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 10, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 11, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 11, idProva = 2, notaAluno = 5.5 },
                new Model.ProvaAluno { idAluno = 11, idProva = 3, notaAluno = 6.5 },

                new Model.ProvaAluno { idAluno = 12, idProva = 1, notaAluno = 7.5 },
                new Model.ProvaAluno { idAluno = 12, idProva = 2, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 12, idProva = 3, notaAluno = 9.5 },

                new Model.ProvaAluno { idAluno = 13, idProva = 1, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 13, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 13, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 14, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 14, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 14, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 15, idProva = 1, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 15, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 15, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 16, idProva = 1, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 16, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 16, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 17, idProva = 1, notaAluno = 2.5 },
                new Model.ProvaAluno { idAluno = 17, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 17, idProva = 3, notaAluno = 6.5 },

                new Model.ProvaAluno { idAluno = 18, idProva = 1, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 18, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 18, idProva = 3, notaAluno = 3.5 },

                new Model.ProvaAluno { idAluno = 19, idProva = 1, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 19, idProva = 2, notaAluno = 9.5 },
                new Model.ProvaAluno { idAluno = 19, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 20, idProva = 1, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 20, idProva = 2, notaAluno = 7.5 },
                new Model.ProvaAluno { idAluno = 20, idProva = 3, notaAluno = 9.0 },

                new Model.ProvaAluno { idAluno = 21, idProva = 1, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 21, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 21, idProva = 3, notaAluno = 7.0 },

                new Model.ProvaAluno { idAluno = 22, idProva = 1, notaAluno = 7.0 },
                new Model.ProvaAluno { idAluno = 22, idProva = 2, notaAluno = 8.0 },
                new Model.ProvaAluno { idAluno = 22, idProva = 3, notaAluno = 9.0 },

                new Model.ProvaAluno { idAluno = 23, idProva = 1, notaAluno = 8.0 },
                new Model.ProvaAluno { idAluno = 23, idProva = 2, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 23, idProva = 3, notaAluno = 7.0 },

                new Model.ProvaAluno { idAluno = 24, idProva = 1, notaAluno = 5.0 },
                new Model.ProvaAluno { idAluno = 24, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 24, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 25, idProva = 1, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 25, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 25, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 26, idProva = 1, notaAluno = 9.5 },
                new Model.ProvaAluno { idAluno = 26, idProva = 2, notaAluno = 9.5 },
                new Model.ProvaAluno { idAluno = 26, idProva = 3, notaAluno = 9.0 },

                new Model.ProvaAluno { idAluno = 27, idProva = 1, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 27, idProva = 2, notaAluno = 8.0 },
                new Model.ProvaAluno { idAluno = 27, idProva = 3, notaAluno = 9.5 },

                new Model.ProvaAluno { idAluno = 28, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 28, idProva = 2, notaAluno = 5.5 },
                new Model.ProvaAluno { idAluno = 28, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 29, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 29, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 29, idProva = 3, notaAluno = 5.5 },

                new Model.ProvaAluno { idAluno = 30, idProva = 1, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 30, idProva = 2, notaAluno = 4.0 },
                new Model.ProvaAluno { idAluno = 30, idProva = 3, notaAluno = 5.5 },

                new Model.ProvaAluno { idAluno = 31, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 31, idProva = 2, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 31, idProva = 3, notaAluno = 7.0 },

                new Model.ProvaAluno { idAluno = 32, idProva = 1, notaAluno = 7.0 },
                new Model.ProvaAluno { idAluno = 32, idProva = 2, notaAluno = 8.0 },
                new Model.ProvaAluno { idAluno = 32, idProva = 3, notaAluno = 9.0 },

                new Model.ProvaAluno { idAluno = 33, idProva = 1, notaAluno = 8.0 },
                new Model.ProvaAluno { idAluno = 33, idProva = 2, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 33, idProva = 3, notaAluno = 7.0 },

                new Model.ProvaAluno { idAluno = 34, idProva = 1, notaAluno = 4.0 },
                new Model.ProvaAluno { idAluno = 34, idProva = 2, notaAluno = 3.0 },
                new Model.ProvaAluno { idAluno = 34, idProva = 3, notaAluno = 7.0 },

                new Model.ProvaAluno { idAluno = 35, idProva = 1, notaAluno = 3.0 },
                new Model.ProvaAluno { idAluno = 35, idProva = 2, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 35, idProva = 3, notaAluno = 7.0 },

                new Model.ProvaAluno { idAluno = 36, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 36, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 36, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 37, idProva = 1, notaAluno = 5.5 },
                new Model.ProvaAluno { idAluno = 37, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 37, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 38, idProva = 1, notaAluno = 5.0 },
                new Model.ProvaAluno { idAluno = 38, idProva = 2, notaAluno = 4.0 },
                new Model.ProvaAluno { idAluno = 38, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 39, idProva = 1, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 39, idProva = 2, notaAluno = 4.0 },
                new Model.ProvaAluno { idAluno = 39, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 40, idProva = 1, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 40, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 40, idProva = 3, notaAluno = 8.0 },

                new Model.ProvaAluno { idAluno = 41, idProva = 1, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 41, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 41, idProva = 3, notaAluno = 7.0 },

                new Model.ProvaAluno { idAluno = 42, idProva = 1, notaAluno = 7.5 },
                new Model.ProvaAluno { idAluno = 42, idProva = 2, notaAluno = 6.0 },
                new Model.ProvaAluno { idAluno = 42, idProva = 3, notaAluno = 9.0 },

                new Model.ProvaAluno { idAluno = 43, idProva = 1, notaAluno = 8.3 },
                new Model.ProvaAluno { idAluno = 43, idProva = 2, notaAluno = 6.4 },
                new Model.ProvaAluno { idAluno = 43, idProva = 3, notaAluno = 7.7 },

                new Model.ProvaAluno { idAluno = 44, idProva = 1, notaAluno = 4.4 },
                new Model.ProvaAluno { idAluno = 44, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 44, idProva = 3, notaAluno = 7.8 },

                new Model.ProvaAluno { idAluno = 45, idProva = 1, notaAluno = 3.8 },
                new Model.ProvaAluno { idAluno = 45, idProva = 2, notaAluno = 6.7 },
                new Model.ProvaAluno { idAluno = 45, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 46, idProva = 1, notaAluno = 6.3 },
                new Model.ProvaAluno { idAluno = 46, idProva = 2, notaAluno = 4.4 },
                new Model.ProvaAluno { idAluno = 46, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 47, idProva = 1, notaAluno = 6.2 },
                new Model.ProvaAluno { idAluno = 47, idProva = 2, notaAluno = 4.1 },
                new Model.ProvaAluno { idAluno = 47, idProva = 3, notaAluno = 8.4 },

                new Model.ProvaAluno { idAluno = 48, idProva = 1, notaAluno = 6.4 },
                new Model.ProvaAluno { idAluno = 48, idProva = 2, notaAluno = 4.3 },
                new Model.ProvaAluno { idAluno = 48, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 49, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 49, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 49, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 50, idProva = 1, notaAluno = 6.8 },
                new Model.ProvaAluno { idAluno = 50, idProva = 2, notaAluno = 4.7 },
                new Model.ProvaAluno { idAluno = 50, idProva = 3, notaAluno = 8.8 },

                new Model.ProvaAluno { idAluno = 51, idProva = 1, notaAluno = 6.4 },
                new Model.ProvaAluno { idAluno = 51, idProva = 2, notaAluno = 4.6 },
                new Model.ProvaAluno { idAluno = 51, idProva = 3, notaAluno = 7.8 },

                new Model.ProvaAluno { idAluno = 52, idProva = 1, notaAluno = 7.5 },
                new Model.ProvaAluno { idAluno = 52, idProva = 2, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 52, idProva = 3, notaAluno = 9.5 },

                new Model.ProvaAluno { idAluno = 53, idProva = 1, notaAluno = 8.5 },
                new Model.ProvaAluno { idAluno = 53, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 53, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 54, idProva = 1, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 54, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 54, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 55, idProva = 1, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 55, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 55, idProva = 3, notaAluno = 7.5 },

                new Model.ProvaAluno { idAluno = 56, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 56, idProva = 2, notaAluno = 3.5 },
                new Model.ProvaAluno { idAluno = 56, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 57, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 57, idProva = 2, notaAluno = 5.5 },
                new Model.ProvaAluno { idAluno = 57, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 58, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 58, idProva = 2, notaAluno = 7.5 },
                new Model.ProvaAluno { idAluno = 58, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 59, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 59, idProva = 2, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 59, idProva = 3, notaAluno = 8.5 },

                new Model.ProvaAluno { idAluno = 60, idProva = 1, notaAluno = 6.5 },
                new Model.ProvaAluno { idAluno = 60, idProva = 2, notaAluno = 4.5 },
                new Model.ProvaAluno { idAluno = 60, idProva = 3, notaAluno = 8.5 }
            };
            provasAlunos.ForEach(s => context.ProvaAluno.AddOrUpdate(p => p.idProvaAluno, s));
            context.SaveChanges();

        }
    }
}
