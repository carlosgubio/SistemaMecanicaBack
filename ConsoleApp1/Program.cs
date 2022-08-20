﻿using Client.Services;
using SistemaMecanica.Dtos;
using SistemaMecanica.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConsoleApp1
{
    enum Opcoes
    {
        Sair,
        CadastrarCliente,
        CadastrarProfissional,
        CadastrarProduto,
        CadastrarServico,
        CadastrarOrdemServico,
        AtualizarCliente,
        AtualizarProfissional,
        AtualizarProduto,
        AtualizarServico,
        AtualizarOrdemServico,
        RemoverCliente,
        RemoverProfissional,
        RemoverProduto,
        RemoverServico,
        RemoverOrdemServico,
        PesquisarCliente,
        PesquisarProfissional,
        PesquisarProduto,
        PesquisarServico,
        PesquisarOrdemServico
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClientesServices clientesServices = new ClientesServices();
            ProfissionaisServices profissionaisServices = new ProfissionaisServices();
            ProdutosServices produtosServices = new ProdutosServices();
            ServicosServices servicosServices = new ServicosServices();
            OrdensServicoServices ordensServicoServices = new OrdensServicoServices();
            
            Opcoes opcoes;
            Console.WriteLine("======================================");
            Console.WriteLine("Digite a Opção desejada:\n0-Sair\n1-Cadastrar Cliente\n2-Cadastrar Profissional\n3-Cadastrar Produto\n4-Cadastrar Serviço\n5-Cadastrar Ordem de Serviço\n6-Atualizar Cliente" +
                              "\n7-Atualizar Profissional\n8-Atualizar Produto\n9-Atualizar Serviço\n10-Atualizar Ordem de Serviço\n11-Remover Cliente\n12-Remover Profissional\n13-Remover Produto\n14-Remover Serviço" +
                              "\n15-Remover Ordem de Serviço\n16-Pesquisar Cliente\n17-Pesquisar Profissional\n18-Pesquisar Produto\n19-Pesquisar Serviço\n20-Pesquisar Ordem de Serviço");
            opcoes = (Opcoes)Convert.ToInt32(Console.ReadLine());

            while (opcoes != Opcoes.Sair)
            {
                if (opcoes == Opcoes.CadastrarCliente)
                {
                    var cliente = new Clientes();
                    Console.WriteLine("Informe o nome do Cliente:");
                    cliente.NomeCliente = Console.ReadLine();
                    Console.WriteLine("Informe o CPF:");
                    cliente.CpfCliente = Console.ReadLine();
                    Console.WriteLine("Informe o Telefone com DDD:");
                    cliente.TelefoneCliente = Console.ReadLine();
                    Console.WriteLine("Informe o Endereco completo:");
                    cliente.EnderecoCliente = Console.ReadLine();
                    Console.WriteLine("Informe o Veículo:");
                    cliente.VeiculoCliente = Console.ReadLine();
                    Console.WriteLine("Informe a Placa do Veículo:");
                    cliente.PlacaVeiculoCliente = Console.ReadLine();
                    Console.WriteLine("Informe a Cor do Veículo:");
                    cliente.CorVeiculoCliente = Console.ReadLine();
                    clientesServices.Salvar(cliente);
                }
                if (opcoes == Opcoes.CadastrarProfissional)
                {
                    var profissional = new Profissionais();
                    Console.WriteLine("Informe o nome do profissional:");
                    profissional.NomeProfissional = Console.ReadLine();
                    Console.WriteLine("Informe o Cargo do profissional:");
                    profissional.CargoProfissional = Console.ReadLine();
                    profissionaisServices.Salvar(profissional);
                }
                if (opcoes == Opcoes.CadastrarProduto)
                {
                    var produto = new Produtos();
                    Console.WriteLine("Informe a Descrição do pPoduto:");
                    produto.DescricaoPeca = Console.ReadLine();
                    Console.WriteLine("Informe o Valor:");
                    produto.ValorPeca = Convert.ToSingle(Console.ReadLine());
                    produtosServices.Salvar(produto);
                }
                if (opcoes == Opcoes.CadastrarServico)
                {
                    var servico = new Servicos();
                    Console.WriteLine("Informe a Descrição do Serviço:");
                    servico.DescricaoServico = Console.ReadLine();
                    Console.WriteLine("Informe o Valor:");
                    servico.ValorServico = (float)Convert.ToDouble(Console.ReadLine());
                    servicosServices.Salvar(servico);
                }
                if (opcoes == Opcoes.CadastrarOrdemServico)
                {
                    var ordensServico = new OrdensServico();
                    Console.WriteLine("Informe o Id do Cliente:");
                    ordensServico.IdCliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o Id do Profissional:");
                    ordensServico.IdProfissional = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o Id do Serviço:");
                    ordensServico.IdServico = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o Id da Peça:");
                    ordensServico.IdPeca = Convert.ToInt32(Console.ReadLine());

                    ordensServicoServices.Salvar(ordensServico);
                } // não está salvando
                if (opcoes == Opcoes.AtualizarCliente)
                {
                    Clientes clientes = new Clientes();
                    Console.WriteLine("Informe o Nome do Cliente que deseja atualizar:");
                    string nome = Console.ReadLine();
                    var clienteretorno = clientesServices.ConfirmarClientes(nome);


                    if (clienteretorno != null && clienteretorno.NomeCliente == nome)
                    { 
                        Console.WriteLine("O nome cadastrado é: " + clienteretorno.NomeCliente + "\nDigite o novo Nome caso deseje alterar.");
                        clienteretorno.NomeCliente = Console.ReadLine();
                        Console.WriteLine("O CPF cadastrado é: " + clienteretorno.CpfCliente + "\nDigite o novo CPF caso deseje alterar.");
                        clienteretorno.CpfCliente = Console.ReadLine();
                        Console.WriteLine("O Telefone cadastrado é: " + clienteretorno.TelefoneCliente + "\nDigite o novo Telefone caso deseje alterar.");
                        clienteretorno.TelefoneCliente = Console.ReadLine();
                        Console.WriteLine("O Endereço cadastrado é: " + clienteretorno.EnderecoCliente + "\nDigite o novo Endereço caso deseje alterar.");
                        clienteretorno.EnderecoCliente = Console.ReadLine();
                        Console.WriteLine("O Veículo cadastrado é: " + clienteretorno.VeiculoCliente + "\nDigite o novo Veículo caso deseje alterar.");
                        clienteretorno.VeiculoCliente = Console.ReadLine();
                        Console.WriteLine("A placa cadastrada é: " + clienteretorno.PlacaVeiculoCliente + "\nDigite a nova placa caso deseje alterar.");
                        clienteretorno.PlacaVeiculoCliente = Console.ReadLine();
                        Console.WriteLine("A cor cadastrada é: " + clienteretorno.CorVeiculoCliente + "\nDigite a nova Cor caso deseje alterar.");
                        clienteretorno.CorVeiculoCliente = Console.ReadLine();
                        clientesServices.Atualizar(nome, clienteretorno);
                    }
                    
                } //Não está Confirmando o Cliente
                if (opcoes == Opcoes.AtualizarProfissional)
                {
                    Profissionais profissionais = new Profissionais();
                    Console.WriteLine("Informe o nome do Profissional que deseja atualizar:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o(s) dado(s) que deseja Atualizar:");

                    if (profissionais != null && profissionais.NomeProfissional == nome)
                    {
                        Console.WriteLine("O nome cadastrado é: " + profissionais.NomeProfissional + "\nDigite o novo Nome caso deseje alterar.");
                        profissionais.NomeProfissional = Console.ReadLine();
                        Console.WriteLine("O Cargo cadastrado é: " + profissionais.CargoProfissional + "\nDigite o novo Cargo caso deseje alterar.");
                        profissionais.CargoProfissional = Console.ReadLine();
                    }
                    profissionaisServices.Atualizar(nome, profissionais);
                }
                if (opcoes == Opcoes.AtualizarProduto)
                {
                    Produtos produtos = new Produtos();
                    Console.WriteLine("Informe a Descrição da Peça que deseja atualizar:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o(s) dado(s) que deseja Atualizar:");

                    if (produtos != null && produtos.DescricaoPeca == nome)
                    {
                        Console.WriteLine("A descrição da Peça cadastrada é: " + produtos.DescricaoPeca + "\nDigite a nova Descriação da Peça caso deseje alterar.");
                        produtos.DescricaoPeca = Console.ReadLine();
                        Console.WriteLine("O Valor da Peça cadastrada é: " + produtos.ValorPeca + "\nDigite o novo Valor caso deseje alterar.");
                        produtos.ValorPeca = Convert.ToSingle(Console.ReadLine());
                    }
                    produtosServices.Atualizar(nome, produtos);
                }
                if (opcoes == Opcoes.AtualizarServico)
                {
                    Servicos servicos = new Servicos();
                    Console.WriteLine("Informe a Descrição da Peça que deseja atualizar:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o(s) dado(s) que deseja Atualizar:");

                    if (servicos != null && servicos.DescricaoServico == nome)
                    {
                        Console.WriteLine("A descrição da Peça cadastrada é: " + servicos.DescricaoServico + "\nDigite a nova Descrição da Peça caso deseje alterar.");
                        servicos.DescricaoServico = Console.ReadLine();
                        Console.WriteLine("O Valor da Peça cadastrada é: " + servicos.ValorServico + "\nDigite o novo Valor caso deseje alterar.");
                        servicos.ValorServico = Convert.ToSingle(Console.ReadLine());
                    }
                    servicosServices.Atualizar(nome, servicos);
                }
                //if (opcoes == Opcoes.AtualizarOrdemServico)
                //{
                //    OrdensServico ordensServico  = new OrdensServico();
                //    Console.WriteLine("Informe a Descrição da Peça que deseja atualizar:");
                //    string nome = Console.ReadLine();

                //    Console.WriteLine("Informe o(s) dado(s) que deseja Atualizar:");

                //    if (ordensServico != null && ordensServico.DescricaoServico == nome)
                //    {
                //        Console.WriteLine("A descrição da Peça cadastrada é: " + ordensServico.DescricaoServico + "\nDigite a nova Descriação da Peça caso deseje alterar.");
                //        ordensServico.DescricaoServico = Console.ReadLine();
                //        Console.WriteLine("O Valor da Peça cadastrada é: " + ordensServico.ValorServico + "\nDigite o novo Valor caso deseje alterar.");
                //        ordensServico.ValorServico = Convert.ToSingle(Console.ReadLine());
                //    }
                //    servicosServices.Atualizar(nome, servicos);
                //}
                if(opcoes == Opcoes.RemoverCliente)
                {
                    Console.WriteLine("Digite o nome do Cliente para remover:");
                    string nome = Console.ReadLine();
                   clientesServices.Remover(nome);
                }
                if (opcoes == Opcoes.RemoverProfissional)
                {
                    Console.WriteLine("Digite o nome do Profissional para remover:");
                    string nome = Console.ReadLine();
                    profissionaisServices.Remover(nome);

                }
                if (opcoes == Opcoes.RemoverProduto)
                {
                    Console.WriteLine("Digite o nome do Produto para remover:");
                    string nome = Console.ReadLine();
                    produtosServices.Remover(nome);

                }
                if (opcoes == Opcoes.RemoverServico)
                {
                    Console.WriteLine("Digite o nome do Serviço para remover:");
                    string nome = Console.ReadLine();
                    servicosServices.Remover(nome);

                }
                if (opcoes == Opcoes.RemoverOrdemServico)
                {
                    Console.WriteLine("Digite o numero do ID da Ordem de Serviço para remover:");
                    string id = Console.ReadLine();
                    ordensServicoServices.Remover(id);

                }
                if (opcoes == Opcoes.PesquisarCliente)
                {
                    Console.WriteLine("Informe o nome do Cliente:");
                    string cliente = Console.ReadLine();
                    Clientes clientes = new Clientes();
                    if (clientes != null && clientes.NomeCliente == cliente)
                    {
                        Console.WriteLine(clientes.NomeCliente);
                        clientesServices.BuscarPorNomeCliente();
                    }
                    clientesServices.BuscarPorNomeCliente();

                }
                if (opcoes == Opcoes.PesquisarProfissional)
                {
                    Console.WriteLine("Informe o nome do Profissional:");
                    string profissional = Console.ReadLine();
                    Profissionais profissionais = new Profissionais();
                    if (profissionais != null && profissionais.NomeProfissional == profissional)
                    {
                        Console.WriteLine(profissionais.NomeProfissional);
                        profissionaisServices.BuscarPorNomeProfissional();
                    }
                    profissionaisServices.BuscarPorNomeProfissional();

                }
                if (opcoes == Opcoes.PesquisarProduto)
                {
                    Console.WriteLine("Informe a Descrição do Produto:");
                    string produto = Console.ReadLine();
                    Produtos produtos = new Produtos();
                    if (produtos != null && produtos.DescricaoPeca == produto)
                    {
                        Console.WriteLine(produtos.DescricaoPeca);
                        produtosServices.BuscarPorNomeProduto();
                    }
                    produtosServices.BuscarPorNomeProduto();

                }
                if (opcoes == Opcoes.PesquisarServico)
                {
                    Console.WriteLine("Informe a Descrição do Serviço:");
                    string produto = Console.ReadLine();
                    Servicos servicos = new Servicos();
                    if (servicos != null && servicos.DescricaoServico == produto)
                    {
                        Console.WriteLine(servicos.DescricaoServico);
                        servicosServices.BuscarPorDescricaoProduto();
                    }
                    produtosServices.BuscarPorNomeProduto();

                }
                if (opcoes == Opcoes.PesquisarOrdemServico)
                {
                    Console.WriteLine("Informe o ID da Ordem do Serviço:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    OrdensServico ordensServico = new OrdensServico();
                    if (ordensServico != null && ordensServico.IdOrdemServico == id)
                    {
                        Console.WriteLine(ordensServico.IdOrdemServico);
                        ordensServicoServices.BuscarPorIdOrdemServico();
                    }
                    ordensServicoServices.BuscarPorIdOrdemServico();
                }

                Console.WriteLine("======================================");
                Console.WriteLine("Digite a Opção desejada:\n0-Sair\n1-Cadastrar Cliente\n2-Cadastrar Profissional\n3-Cadastrar Produto\n4-Cadastrar Serviço\n5-Cadastrar Ordem de Serviço\n6-Atualizar Cliente" +
                                  "\n7-Atualizar Profissional\n8-Atualizar Produto\n9-Atualizar Serviço\n10-Atualizar Ordem de Serviço\n11-Remover Cliente\n12-Remover Profissional\n13-Remover Produto\n14-Remover Serviço" +
                                  "\n15-Remover Ordem de Serviço\n16-Pesquisar Cliente\n17-Pesquisar Profissional\n18-Pesquisar Produto\n19-Pesquisar Serviço\n20-Pesquisar Ordem de Serviço");
                opcoes = (Opcoes)Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}


    