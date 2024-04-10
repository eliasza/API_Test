using ThomasGregTest.Domain.Interfaces.Services;
using ThomasGregTest.Domain.Models.Logradouro;

namespace ThomasGregTest.API.Routes
{
    public static class LogradouroRouter
    {
        public static void ConfigRoutesLogradouro(this WebApplication app)
        {
            app.MapGet("/Logradouro/{id}", Obter);
            app.MapGet("/Logradouro", ObterTodos);
            app.MapPost("/Logradouro/Adicionar", Adicionar);
            app.MapPut("/Logradouro/Atualizar", Atualizar);
            app.MapDelete("/Logradouro/Remover/{id}", Remover);
        }

        private static async Task<IResult> Obter(int id, ILogradouroService logradouroService)
        {
            try
            {
                var result = await logradouroService.Obter(id);
                return result is null ? Results.NotFound() : Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> ObterTodos(ILogradouroService logradouroService)
        {
            try
            {
                return Results.Ok(await logradouroService.ObterTodos());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Adicionar(LogradouroRequest logradouro, ILogradouroService logradouroService)
        {
            try
            {
                var result = await logradouroService.Adicionar(logradouro);
                return Results.Created($"/Logradouro/{logradouro.Id}", result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Atualizar(LogradouroRequest logradouro, ILogradouroService logradouroService)
        {
            try
            {
                var result = await logradouroService.Atualizar(logradouro);
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> Remover(int id, ILogradouroService logradouroService)
        {
            try
            {
                var result = await logradouroService.Remover(id);
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
