### Comando para baixar RabbitMQ via Docker

```
docker run -d --hostname rabbit-host --name rabbit-nerdstore -p 15672:15672 -p 5672:5672 rabbitmq:management
```

* -p 15672 (Porta de Administração) - Visualização de filas
* -p 5672 (Porta para recebimento de mensagens)

Senha e usuário padrão = guest

### O básico que você precisa saber sobre RabbitMQ

* AMQP: Advanced Message Queuing Protocol
* Exchanges: Responsáveis por receberem as mensagens e enviar para as filas
* Queues: Filas - Local de armazenamento das mensagens
* Bindings: Faz a ligação entre os exchanges e as Filas (Queues)
* Route Keys: Palavras chaves utilizadas no roteamento das mensagens