#language: pt

Funcionalidade: Login Toro

Contexto: Acessar a página de Login da Aplicação
	Dado que o usuário acesse a aplicação
	E entre na página de login

Cenário: Logar na Aplicação com credencias válidas
	Quando o usuário informar credencias válidas
	E clicar no botão Entrar
	Então a aplicação deverá exibir a página inicial com nome do usuário logado

Cenário: Tentar logar na Aplicação sem informar E-mail e Senha
	Quando o usuário clicar no botão Entrar
	Então a aplicação deverá exibir a mensagem 'E-mail inválido' no campo 'E-mail'
	E a mensagem "Senha inválida" no campo "Senha"

Esquema do Cenário: Tentar logar na Aplicação sem informar campos obrigatórios
	Quando o usuário clicar no botão Entrar
	E preencher o campo '<PreenhcerCampo>'
	E clicar no botão Entrar
	Então a aplicação deverá exibir a mensagem '<Mensagem>' no campo '<ValidarCampo>'
	
	Exemplos: 
		| PreenhcerCampo | Mensagem        | ValidarCampo |
		| Email          | Senha inválida  | Senha        |
		| Senha          | E-mail inválido | Email        |

Esquema do Cenário: Tentar logar na Aplicação informando credenciais inválidas
	Quando o usuário clicar no botão Entrar
	E preencher o campo '<Campo>' com um valor inválido
	E clicar no botão Entrar
	Então a aplicação deverá exibir a mensagem "<Mensagem>"
	
	Exemplos: 
		| Campo | Mensagem                            |
		| Email | Dados incorretos. Digite novamente. |
		| Senha | Dados incorretos. Digite novamente. |