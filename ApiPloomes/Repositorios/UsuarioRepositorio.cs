using ApiPloomes.Data;
using ApiPloomes.Models;
using ApiPloomes.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiPloomes.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly SistemaTarefasDBContext _dbContext;
        public UsuarioRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext)
        {
            _dbContext = sistemaTarefasDBContext;
        }   
        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Id == id); 
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            _dbContext.Usuarios.Add(usuario);   
            await _dbContext.SaveChangesAsync();
            return usuario;

        }
        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioId = await BuscarUsuarioPorId(id);
            if(usuarioId == null)
            {
                throw new Exception($"Usuario com id: {id}  não encontrado");
            }
            
            usuarioId.Nome = usuario.Nome;
            usuarioId.Email = usuario.Email;
            _dbContext.Usuarios.Update(usuarioId);
            await _dbContext.SaveChangesAsync();
            return usuarioId;
        }
        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioId = await BuscarUsuarioPorId(id);
            if (usuarioId == null)
            {
                throw new Exception($"Usuario com id: {id}  não encontrado");
            }

            _dbContext.Usuarios.Remove(usuarioId);
            await _dbContext.SaveChangesAsync();
            return true;    
        }

        
    }
}
