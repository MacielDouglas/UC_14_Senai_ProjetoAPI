﻿using ExoApi.Contexts;
using ExoApi.Interfaces;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ExoApiContext _context;

        public UsuarioRepository(ExoApiContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(id);

            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;

                _context.Usuarios.Update(usuarioEncontrado);

                _context.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioEncontrdo = _context.Usuarios.Find(id);

            _context.Usuarios.Remove(usuarioEncontrdo);

        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }
    }
}