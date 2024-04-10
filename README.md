# ThomasGregTest
Teste de desenvolvimento de um projeto

Mazzatech-ThomasGreg
API Thomas Greg Mazzatech

Este sistema foi implementado como uma solução CRUD (Criar, Ler, Atualizar, Excluir) para simplificar o registro e upload de logotipo para os clientes. As solicitações HTTP são responsáveis ​​pela coordenação eficaz, possibilitada por meio de duas APIs principais: as de Cliente e de Local, que possuem seus endpoints para tarefas específicas.

Auth:
POST: Realiza a autenticação do usuário e gera um token para ser usado nas chamadas dos métodos abaixo
Clientes:
GET: Recupera os dados de um cliente específico.
POST: Realiza o cadastro de um novo cliente.
PUT: Atualiza os dados de um cliente existente.
DELETE: Remove um cliente do sistema.
Logradouros:
GET: Obtem informações de um logradouro específico associado a um cliente.
GET All: Lista todos os logradouros vinculados a um cliente.
POST: Adiciona um novo logradouro para um cliente.
PUT: Modifica os detalhes de um logradouro específico de um cliente.
DELETE: Exclui um logradouro da lista de um cliente.
Guia de Instalação
