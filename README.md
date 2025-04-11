# 🛠️ Ferramentas API

API desenvolvida em ASP.NET Core para cadastro e gerenciamento de ferramentas industriais. Utiliza boas práticas como arquitetura em camadas, Value Objects, Enum para tipos de ferramentas e endpoints organizados.

## 🚀 Tecnologias

- ASP.NET Core 7
- C#
- Swagger / Swashbuckle
- Injeção de Dependência
- Programação Orientada a Objetos
- Boas práticas com Value Objects e Tipos Ricos

## 🧱 Estrutura do Projeto

```
FerramentasSolution/
├── FerramentasAPI/               # Camada da API (Endpoints, Swagger)
│   ├── Dtos/                     # Objetos de transferência de dados
│   ├── Endpoints/               # Endpoints organizados por operação
│   └── Program.cs               # Configuração e inicialização
│
├── FerramentasDomain/           # Camada de domínio
│   ├── Entities/                # Entidades de domínio (ex: FerramentaBase)
│   ├── Enums/                   # Enums (ex: TipoFerramenta)
│   ├── Repositories/            # Interfaces dos repositórios
│   └── ValueObjects/            # Tipos ricos com validações
```

## 📌 Endpoints Disponíveis

### ✅ Criar ferramenta (POST)

`POST /ferramentas`

```json
{
  "descricao": "Ferramenta de perfuração",
  "endereco": "Estoque A",
  "diametro": 2.5,
  "altura": 10.0,
  "tipo": 1
}
```

### 📄 Obter ferramenta por ID (GET)

`GET /ferramentas/{id}`

### 📃 Listar todas as ferramentas (GET)

`GET /ferramentas`

### ✏️ Atualizar ferramenta (PUT)

`PUT /ferramentas/{id}`

```json
{
  "descricao": "Ferramenta Topo Raso Atualizada",
  "endereco": "Estoque B",
  "diametro": 3.0,
  "altura": 8.0,
  "tipo": 2
}
```

### ❌ Deletar ferramenta (DELETE)

`DELETE /ferramentas/{id}`

## 📚 Enum `TipoFerramenta`

| Valor | Tipo        |
|-------|-------------|
| 1     | VBit        |
| 2     | TopoRaso    |

## 🔄 Rodando o projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/ferramentas-api.git
   ```

2. Vá para a pasta:
   ```bash
   cd FerramentasSolution/FerramentasAPI
   ```

3. Rode o projeto:
   ```bash
   dotnet run
   ```

4. Acesse o Swagger em:
   ```
   [https://localhost:44393/swagger]
   ```

## 🧪 Testes

A API pode ser testada diretamente pelo Swagger UI com os exemplos fornecidos acima.

---

📌 Feito com por Bruno  
