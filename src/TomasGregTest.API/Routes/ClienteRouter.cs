using ThomasGregTest.Application.Services;
using ThomasGregTest.Domain.Interfaces.Services;
using ThomasGregTest.Domain.Models.Cliente;
using ThomasGregTest.Infra.Data.Repositories;

namespace ThomasGregTest.API.Routes
{
    public static class ClienteRouter
    {
        public static void ConfigRoutesCliente(this WebApplication app)
        {
            app.MapGet("/Cliente/{id:int}", Obter);
            app.MapGet("/Cliente/Completo/{id:int}", ObterComEndereco);
            app.MapGet("/Cliente", ObterTodos);
            app.MapPost("/Cliente/Adicionar", Adicionar);
            app.MapPost("/Cliente/AdicionarComEndereco", AdicionarComEndereco);
            app.MapPut("/Cliente/Atualizar", Atualizar);
            app.MapDelete("/Cliente/Remover/{id:int}", Remover);
        }

        private static async Task<IResult> Obter(int id, IClienteService clienteService)
        {
            try
            {
                var result = await clienteService.Obter(id);
                return result is null ? Results.NotFound() : Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> ObterComEndereco(int id, IClienteService clienteService)
        {
            try
            {
                var result = await clienteService.ObterComEnderecos(id);
                return result is null ? Results.NotFound() : Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> ObterTodos(IClienteService clienteService)
        {
            try
            {
                return Results.Ok(await clienteService.ObterTodos());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Adicionar(ClienteRequest cliente, IClienteService clienteService)
        {
            try
            {
                var _clienteExistente = await clienteService.ObterPorEmail(cliente.Email);
                if (_clienteExistente != null && _clienteExistente.Id != cliente.Id) throw new Exception("Já existe um cliente com este email!");

                var result = await clienteService.Adicionar(cliente);
                return Results.Created($"/Cliente/{cliente.Id}", result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> AdicionarComEndereco(ClienteRequest cliente, IClienteService clienteService)
        {
            try
            {
                var _clienteExistente = await clienteService.ObterPorEmail(cliente.Email);
                if (_clienteExistente != null && _clienteExistente.Id != cliente.Id) throw new Exception("Já existe um cliente com este email!");

                var result = await clienteService.AdicionarComEnderecos(cliente);
                return Results.Created($"/Cliente/{cliente.Id}", result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Atualizar(ClienteRequest cliente, IClienteService clienteService)
        {
            try
            {
                var _cliente = await clienteService.Atualizar(cliente);
                return  Results.Ok(_cliente);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Remover(int id, IClienteService clienteService)
        {
            try
            {
                var result = await clienteService.Remover(id);
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
