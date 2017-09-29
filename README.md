# EventPayment - Api

URL `http://api-eventpayment.azurewebsites.net`

Obs: O endpoint de acesso a api começa no /api/


## Documentação

- (Evento)[https://github.com/giioohbernini/eventopay-api/wiki/Event-Documentation]
- (Usuáro)[https://github.com/giioohbernini/eventopay-api/wiki/User-Documentation]

## Endpoints

- `http://api-eventpayment.azurewebsites.net/api/usuario` 
- `http://api-eventpayment.azurewebsites.net/api/evento`







/*api am*/
Função - Comprar credito
Caminho - api/credito
Metodo HTTP- Post:(int IdUsuario, double Valor)
*******************************************************************************
Função - Cadastrar Usuario
Caminho - api/usuario
Metodo HTTP- Post:(Usuario usuario)
******************************
Função - Listar todos Usuarios
Caminho - api/usuario
Metodo HTTP- GET
******************************
Função - Procura um Usuario
Caminho - api/usuario/id
Metodo HTTP- GET
******************************
Função - Alterar um Usuario
Caminho - api/usuario/id
Metodo HTTP- Put (int id, Usuario usuario)
******************************
Função - Deletar um Usuario
Caminho - api/usuario/id
Metodo HTTP- Delete
***************************************************************************
Função - Listar todas as transaçoes por Usuario
Caminho - api/transacao/id_usuario
Metodo HTTP- GET
******************************
Função -Cadastrar transaçao 
Caminho - api/transacao
Metodo HTTP- Post(Transacao transacao)
***************************************************************************
Função - Lista todos Eventos
Caminho - api/Evento
Metodo HTTP- GET
******************************
Função - Procura Evento
Caminho - api/Evento/id
Metodo HTTP- GET
******************************
Função - Cadastra Evento
Caminho - api/Evento
Metodo HTTP- Post(Evento evento)
******************************
Função - Edita Evento
Caminho - api/Evento/id
Metodo HTTP- Put(int id, Evento evento)
******************************
Função - Deleta Evento
Caminho - api/Evento/id
Metodo HTTP- Delete
***************************************************************************
Função - Fazer Login
Caminho - api/Login
Metodo HTTP- Post(string Nome, string Senha)
***************************************************************************
