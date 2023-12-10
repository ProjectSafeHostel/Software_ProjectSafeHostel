﻿using Microsoft.EntityFrameworkCore;
using ProjectSafeHostel.Dados.EntityFramework;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public ClienteRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task AtualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> BuscarPorId(int id)
        {
            var cliente = await _contexto.Cliente.Where(c => c.CLIENTE_ID == id).FirstOrDefaultAsync();

            return cliente;
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            try
            {
                var cliente = _contexto.Cliente.Where(c => c.ATIVO_FLAG == 0).ToList();

                return cliente;
            }        
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar cliente: {ex.Message}");
            }
        }

        public async Task ExcluirCliente(Cliente cliente)
        {
            try
            {
                _contexto.Cliente.Remove(cliente);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir cliente: {ex.Message}");
            }
        }

        public async Task InserirCliente(Cliente cliente)
        {
            try
            {
                await _contexto.Cliente.AddAsync(cliente);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir cliente: {ex.Message}");
            }
        }
    }
}
