# 🧱 Pokemon Tower Defense (Unity)

Este repositório contém a estrutura do projeto *Pokemon Tower Defense*, desenvolvido em Unity por uma equipe com background em engenharia de software. Nosso objetivo é aplicar práticas profissionais de versionamento, colaboração e organização de código no desenvolvimento de jogos.

## 🎯 Objetivo

Aprender e aplicar desenvolvimento de jogos em Unity utilizando GitHub para versionamento e colaboração. Estamos priorizando um fluxo de trabalho escalável e seguro para equipes pequenas, evitando problemas comuns como conflitos em cenas e versionamento incorreto de arquivos grandes.

---

## 📁 Estrutura de Pastas

```plaintext
Assets/
├── _Project/           # Código e assets do nosso jogo (organizado por features)
│   ├── Features/       # Código por funcionalidades: Towers, Enemies, UI, Gameplay
│   ├── Audio/          # Músicas e efeitos sonoros
│   ├── Materials/      # Materiais compartilhados
│   ├── Scenes/         # Cenas do jogo (MainMenu, Level01, etc.)
│   ├── ScriptableObjects/ # Definições de dados reutilizáveis
│   ├── Shaders/        # Shaders personalizados
├── Editor/             # Scripts que só rodam no editor
├── Plugins/            # Assets externos (se necessário)
├── StreamingAssets/    # Arquivos acessados como arquivos soltos no build
```

## ✅ Boas Práticas com Unity + GitHub

### 1. Use um `.gitignore` robusto
Utilize o modelo oficial do GitHub para Unity:
👉 https://github.com/github/gitignore/blob/main/Unity.gitignore

> **Importante**: a pasta `Library/` **nunca** deve ser versionada. Se já foi, use:
```bash
git rm -r --cached Library/
git commit -m "Removendo arquivos indevidos"
git push
```

### 2. Configure o Unity para serializar assets como texto
Vá em: `Edit > Project Settings > Editor > Asset Serialization > Mode = Force Text`
Isso permite visualizar diferenças (diff) e tentar merges em arquivos `.prefab` e `.unity`.

### 3. Evite conflitos em cenas e prefabs
- **Divida o trabalho**: um dev por prefab/cena
- **Use prefabs aninhados e cenas aditivas**
- **Comuniquem-se constantemente**
- **Não confiem no merge automático** — mesmo com serialização de texto, o risco de corromper a cena/prefab é real

### 4. Mantenham a mesma versão do Unity
Todos devem usar **exatamente** a mesma versão (ex: `2022.3.10f1`). Isso evita problemas de compatibilidade e corrupção de arquivos.

### 📁 Git LFS (Large File Storage)

Unity trabalha com muitos arquivos binários pesados (texturas, áudio, modelos 3D), e o Git tradicional não lida bem com isso. Para evitar problemas de desempenho e limites do GitHub, usamos **Git LFS** para gerenciar esses arquivos.

#### ✅ Como configurar

1. **Instale o Git LFS**

Acesse: https://git-lfs.github.com/
Ou instale via terminal:

```bash
# Windows/macOS/Linux
git lfs install
```

Se clonou o repositório antes de instalar git lfs, rode:
```bash
git lfs pull
```


## 🚀 Fluxo de Trabalho com Git

- Usamos **Git Flow** para organizar nosso desenvolvimento:
  - `main` → versão estável
  - `develop` → integrações em progresso
  - `feature/nome-da-feature` → novas funcionalidades
- Commits pequenos e frequentes
- Faça `git pull` regularmente
- Antes de dar `push`, **abra o projeto no Unity e teste**


## 🧠 Considerações Finais

Apesar das dificuldades iniciais, o GitHub é amplamente utilizado com Unity. Com as configurações e práticas certas, é possível ter um fluxo de trabalho robusto e confiável, mesmo para jogos complexos. Alternativas como Unity Cloud (Plastic SCM) oferecem soluções especializadas, mas não são obrigatórias.

> 👾 Esse projeto é tanto um experimento técnico quanto um laboratório de aprendizado. Nosso foco está em aplicar a engenharia de software ao desenvolvimento de jogos — com disciplina, clareza e boas práticas.


## 🔧 Requisitos

- Unity **6000.0.47f1**
- Git + Git LFS
