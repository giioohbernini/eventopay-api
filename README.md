# EventPayment - Api

URL `http://api-eventpayment.azurewebsites.net`

Obs: O endpoint de acesso a api começa no /api/


## Documentação

- (Evento)[https://github.com/giioohbernini/eventopay-api/wiki/Event-Documentation]
- (Usuáro)[https://github.com/giioohbernini/eventopay-api/wiki/User-Documentation]

## Endpoints

- `http://api-eventpayment.azurewebsites.net/api/usuario` 
- `http://api-eventpayment.azurewebsites.net/api/evento`






*******************************************************************************

Função - Comprar credito<br>
Caminho - api/credito<br>
Metodo HTTP- Post:(int IdUsuario, double Valor)<br>
*******************************************************************************
Função - Cadastrar Usuario<br>
Caminho - api/usuario<br>
Metodo HTTP- Post:(Usuario usuario)<br>
******************************
Função - Listar todos Usuarios<br>
Caminho - api/usuario<br>
Metodo HTTP- GET<br>
******************************
Função - Procura um Usuario<br>
Caminho - api/usuario/id<br>
Metodo HTTP- GET<br>
******************************
Função - Alterar um Usuario<br>
Caminho - api/usuario/id<br>
Metodo HTTP- Put (int id, Usuario usuario)<br>
******************************
Função - Deletar um Usuario<br>
Caminho - api/usuario/id<br>
Metodo HTTP- Delete<br>
***************************************************************************
Função - Listar todas as transaçoes por Usuario<br>
Caminho - api/transacao/id_usuario<br>
Metodo HTTP- GET<br>
******************************
Função -Cadastrar transaçao <br>
Caminho - api/transacao<br>
Metodo HTTP- Post(Transacao transacao)<br>
***************************************************************************
Função - Lista todos Eventos<br>
Caminho - api/Evento<br>
Metodo HTTP- GET<br>
******************************
Função - Procura Evento<br>
Caminho - api/Evento/id<br>
Metodo HTTP- GET<br>
******************************
Função - Cadastra Evento<br>
Caminho - api/Evento<br>
Metodo HTTP- Post(Evento evento)<br>
******************************
Função - Edita Evento<br>
Caminho - api/Evento/id<br>
Metodo HTTP- Put(int id, Evento evento)<br>
******************************
Função - Deleta Evento<br>
Caminho - api/Evento/id<br>
Metodo HTTP- Delete<br>
***************************************************************************
Função - Fazer Login<br>
Caminho - api/Login<br>
Metodo HTTP- Post(string Nome, string Senha)<br>
***************************************************************************
