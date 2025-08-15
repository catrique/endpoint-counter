# 🧮 Contador de Endpoints

**Contador de Endpoints** é uma ferramenta simples em .NET criada para ajudar **QAs iniciantes** a contar automaticamente os endpoints expostos por uma API ASP.NET.  
Ela analisa os controllers do projeto via reflexão, identifica os métodos HTTP (como `[HttpGet]`, `[HttpPost]`, etc.) e exibe a contagem total no console.

---

## 🎯 Objetivo

Facilitar o acompanhamento da cobertura de testes em APIs REST, evitando a contagem manual de endpoints.  
Ideal para quem está começando na área de QA e precisa saber quantos testes já foram feitos em relação ao total de endpoints disponíveis.

---

## ⚙️ Como funciona

O código carrega o assembly da API (`Events.API`), identifica todos os controllers públicos e não abstratos, e conta os métodos que possuem atributos HTTP (`HttpGet`, `HttpPost`, etc.).

---

## 🛠️ Tecnologias utilizadas

- .NET 9  
- ASP.NET Core  
- System.Reflection  
- Microsoft.AspNetCore.Mvc  

---

## 🚀 Como usar

### 1. Clone o repositório

```bash
git clone https://github.com/catrique/endpoint-counter.git
cd contador-de-endpoints
```

### 2. Configure o nome do assembly

No arquivo `Program.cs`, altere a linha abaixo para o nome exato do seu projeto ASP.NET:

```csharp
var assembly = Assembly.Load("Events.API");
```

### 3. Compile e execute

```bash
dotnet run
```

### 4. Veja o resultado no console

```
📁 UserController: 7 endpoints
📁 ProductController: 5 endpoints

🔢 Total de endpoints encontrados: 12
```

---

## 📁 Estrutura do projeto

```
ContadorDeEndpoints/
├── .gitignore
├── ContadorDeEndpoints.csproj
├── ContadorDeEndpoints.sln
├── LICENSE
├── Program.cs
└── README.md
```

---

## 🤝 Contribuições

Sugestões e melhorias são bem-vindas!  
Se quiser adicionar novos recursos ou adaptar para outros tipos de projeto, sinta-se à vontade para abrir uma issue ou pull request.
