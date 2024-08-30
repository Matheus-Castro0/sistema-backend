using ProgramacaoDoZero.Common;
using ProgramacaoDoZero.Entities;
using ProgramacaoDoZero.Models;
using ProgramacaoDoZero.Repositories;
using System;

namespace ProgramacaoDoZero.Services
{
    public class UsuarioService
    {
        private string _connectionString;

        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public LoginResult Login(string email, string senha)
        {
            var result = new LoginResult();

            var UsuarioRepository = new UsuarioRepository(_connectionString);

            var usuario = UsuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario != null)
            {
                //usuario existe
                if (usuario.Senha == senha)
                {
                    //senha válida
                    result.sucesso = true;
                    result.usuarioGuid = usuario.UsuarioGuid;
                }
                else
                {
                    //senha inválida
                    result.sucesso = false;
                    result.mensagem = "Usuário ou senha inválidos.";
                }
            }

            else
            {
                //usuario não existe
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos.";
            }

            return result;
        }

        public CadastroResult Cadastro(string nome, string sobrenome, string telefone, string email, string genero, string senha)
        {
            var result = new CadastroResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario != null)
            {
                //usuario já existe
                result.sucesso = false;
                result.mensagem = "Usuário já existe no sistema.";
            }

            else
            {
                //usuário não existe
                usuario = new Usuario();
                
                usuario.Nome = nome;
                usuario.Sobrenome = sobrenome;
                usuario.Telefone = telefone;
                usuario.Email = email;
                usuario.Genero = genero;
                usuario.Senha = senha;
                usuario.UsuarioGuid = Guid.NewGuid();

                var affectedRows = usuarioRepository.Inserir(usuario);

                if (affectedRows > 0)
                {
                    result.sucesso = true;
                    result.usuarioGuid = usuario.UsuarioGuid;
                }

                else
                {
                    result.sucesso = false;
                    result.mensagem = "Não foi possível inserir o usuário";
                }
            }

            return result;
        }

        public EsqueceuSenhaResult EsqueceuSenha(string email)
        {
            var result = new EsqueceuSenhaResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario == null)
            {
                //usuario não existe
                result.sucesso = false;
                result.mensagem = "Usuário não existe para esse E-Mail.";
            }
            else
            {
                //usuario existe
                var emailSender = new EmailSender();

                var assunto = "Recuperação de senha.";
                var corpo = "Sua senha é " + usuario.Senha;

                emailSender.Enviar(assunto, corpo, usuario.Email);
            }

            return result;
        }
        
        public Usuario ObterUsuario(Guid usuarioGuid)
        {
            var usuario = new UsuarioRepository(_connectionString).ObterPorGuid(usuarioGuid);

            return usuario;
        }
    }
}
