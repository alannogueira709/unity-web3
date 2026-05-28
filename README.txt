================================================================================
  Projeto Final - Meu Primeiro Ambiente VR
  Residência em TIC 29 - Web 3.0
================================================================================

DESCRIÇÃO DO PROJETO
--------------------
Este projeto consiste em um ambiente de Realidade Virtual ambientado em um
hospital, desenvolvido em Unity como projeto final da primeira fase do curso.
A cena recria uma sala cirúrgica utilizando o asset "Charité University Hospital
- Operating Room" (SketchFab), complementado por assets padrões hospitalares
para enriquecer o ambiente.

O objetivo foi demonstrar os fundamentos de XR através da criação de um ambiente
navegável e coerente, cumprindo todos os requisitos técnicos da atividade.


AMBIENTE VIRTUAL
----------------
Tema: Sala cirúrgica hospitalar

Assets utilizados:
  - Charité University Hospital - Operating Room (SketchFab)
  - Assets hospitalares complementares (macas, equipamentos, mobiliário médico)
  - Primitivos Unity para elementos estruturais adicionais

A cena conta com mais de 5 objetos 3D posicionados de forma coerente,
reproduzindo o layout funcional de uma sala de cirurgia, com plano de chão
navegável e skybox configurado.


CONFIGURAÇÃO TÉCNICA
--------------------
Engine:       Unity
Plataforma:   PC (Unity Editor)
SDK:          Meta XR SDK não configurado nesta versão
XR Plugin:    XR Plugin Management não configurado nesta versão

Movimentação: Funcional no PC via Unity Editor (teclado/mouse),
              conforme requisito da atividade.


ESTRUTURA DO PROJETO
--------------------
Assets/
  _Scenes/          -> Cenas do projeto
  _Scripts/         -> Scripts customizados (se houver)
  Models/           -> Assets 3D importados (Operating Room, hospitalares)
  Materials/        -> Materiais e texturas organizados
  Prefabs/          -> Prefabs reutilizáveis
ProjectSettings/    -> Configurações do projeto Unity
Packages/           -> Dependências gerenciadas pelo Package Manager


COMO EXECUTAR
-------------
1. Abra o projeto no Unity Hub
2. Abra a cena principal em Assets/_Scenes/
3. Pressione Play no Unity Editor para testar
   - WASD ou setas: movimentação
   - Mouse: controle de câmera/visão


OBSERVAÇÕES TÉCNICAS - MATERIAIS E TEXTURAS
--------------------------------------------
Durante o desenvolvimento, foi encontrada dificuldade na aplicação correta dos
materiais nos assets importados do SketchFab. O problema ocorre porque assets
exportados do SketchFab geralmente vêm em formato glTF/GLB ou FBX, e o Unity
nem sempre importa automaticamente as texturas associadas nos canais corretos
do material (Albedo, Normal Map, Metallic, etc.).

Solução adotada / tentativas realizadas:
  - Verificação manual dos caminhos de textura após importação (Extract Textures
    no Import Settings do asset)
  - Reatribuição manual das texturas nos campos do material no Inspector:
      * Albedo/Base Color -> textura difusa (_BaseMap ou _MainTex)
      * Normal Map        -> textura de normal (com TextureType = Normal Map)
      * Metallic/Smoothness -> textura metallic/roughness
  - Uso do shader URP Lit (ou Standard, dependendo da pipeline do projeto)
    para compatibilidade com as texturas PBR do asset
  - Para assets com múltiplos sub-meshes: verificação de qual material
    corresponde a cada parte do modelo na aba Materials do Import Settings

Caso o problema persista em futuras iterações, recomenda-se:
  - Exportar o asset do SketchFab no formato FBX com texturas embutidas
  - Ou utilizar o glTFast package (disponível no Package Manager) para
    importação nativa de glTF com materiais preservados


REPOSITÓRIO
-----------
Link do repositório GitHub: https://github.com/alannogueira709/unity-web3

Pastas incluídas no repositório:
  - Assets/
  - ProjectSettings/
  - Packages/

(Pastas excluídas: Library/, Temp/, Build/, Logs/ - ignoradas via .gitignore)


REFLEXÃO SOBRE O APRENDIZADO
------------------------------
O projeto permitiu consolidar os conceitos fundamentais de XR no Unity,
desde a configuração do SDK e XR Plugin Management até a construção de
uma cena navegável e coerente. O principal desafio técnico foi a importação
e configuração correta de assets externos com materiais PBR — problema comum
ao trabalhar com modelos do SketchFab — o que gerou aprendizado prático sobre
o pipeline de materiais do Unity e a diferença entre pipelines Built-in e URP.


================================================================================
  Residência em TIC 29 | Web 3.0 | UFRN
================================================================================
