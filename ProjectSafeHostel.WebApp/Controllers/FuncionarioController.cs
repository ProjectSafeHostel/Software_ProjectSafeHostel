using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Dados.EntityFramework;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Servico.ViewModels;
using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;

namespace ProjectSafeHostel.WebApp.Controllers
{
    public class FuncionarioController : Controller
    {
        //private Contexto _contexto = new Contexto();
        private readonly Contexto _contexto;
        private const int ItensPorPagina = 6;

        public FuncionarioController(Contexto contexto)
        {
            _contexto = contexto;
        }


        public IActionResult Index(int pagina = 1)
        {
            var todosColaboradores = _contexto.Colaborador.Where(f =>
                f.TIPO == 'F'
                && f.DATA_TERMINACAO == null
            ).ToList(); 

            var itensPaginados = todosColaboradores.Skip((pagina - 1) * ItensPorPagina).Take(ItensPorPagina).ToList();

            var viewModel = new PaginacaoViewModel<Colaborador>
            {
                Itens = itensPaginados,
                Paginacao = new Paginacao
                {
                    ItensPorPagina = ItensPorPagina,
                    PaginaAtual = pagina,
                    TotalItens = todosColaboradores.Count
                }
            };

            return View(viewModel);
        }

        public IActionResult CadastrarFuncionario()
        {
            var funcionario = new CadastrarFuncionarioViewModel();
            return View(funcionario);
        }


        [HttpPost]
        public IActionResult Post(CadastrarFuncionarioViewModel funcionarioCadastrado)
        {
            Colaborador novoColaborador = new Colaborador
            {
                NOME = funcionarioCadastrado.Colaborador.NOME,
                SOBRENOME = funcionarioCadastrado.Colaborador.SOBRENOME,
                DATA_NASCIMENTO = funcionarioCadastrado.Colaborador.DATA_NASCIMENTO,
                TIPO = 'F',
                CPF = funcionarioCadastrado.Colaborador.CPF,
                DATA_CONTRATACAO = DateTime.Now,
                DATA_TERMINACAO = null,
                TERMINACAO_FLAG = 1
            };
            _contexto.Colaborador.Add(novoColaborador);
            _contexto.SaveChanges();

            int colaboradorIdGerado = novoColaborador.COLABORADOR_ID;

            Endereco novoEndereco = new Endereco
            {
                LOGRADOURO = funcionarioCadastrado.Endereco.LOGRADOURO,
                NUMERO = funcionarioCadastrado.Endereco.NUMERO,
                COMPLEMENTO = funcionarioCadastrado.Endereco.COMPLEMENTO != "" ? funcionarioCadastrado.Endereco.COMPLEMENTO : null,
                CIDADE = funcionarioCadastrado.Endereco.CIDADE,
                CEP = funcionarioCadastrado.Endereco.CEP != "" ? funcionarioCadastrado.Endereco.CEP : null,
                COLABORADOR_ID = colaboradorIdGerado
            };
            _contexto.Endereco.Add(novoEndereco);
            _contexto.SaveChanges();

            Funcionario novoFuncionario = new Funcionario
            {
                FUNCAO = funcionarioCadastrado.Funcionario.FUNCAO,
                SALARIO = funcionarioCadastrado.Funcionario.SALARIO,
                COLABORADOR_ID = colaboradorIdGerado
            };
            _contexto.Funcionario.Add(novoFuncionario);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id)
        {
            var colaboradorExcluido = _contexto
                .Colaborador.FirstOrDefault(c => c.COLABORADOR_ID == id);

            var funcionarioExcluido = _contexto
                .Funcionario.FirstOrDefault(f => f.COLABORADOR_ID == id);

            var EnderecoExcluido = _contexto
                .Endereco.FirstOrDefault(e => e.COLABORADOR_ID == id);

            _contexto.Funcionario.Remove(funcionarioExcluido);
            _contexto.SaveChanges();

            _contexto.Endereco.Remove(EnderecoExcluido);
            _contexto.SaveChanges();

            _contexto.Colaborador.Remove(colaboradorExcluido); 
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
