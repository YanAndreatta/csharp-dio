#!/bin/bash

# Solicitação de confirmação do usuário para adicionar arquivos
read -p "Deseja adicionar todos os arquivos modificados? (s/n): " add_files
if [ "$add_files" = "s" ]; then
    git add .
fi

# Solicitação de confirmação do usuário para fazer commit
read -p "Deseja fazer commit das alterações? (s/n): " commit_changes
if [ "$commit_changes" = "s" ]; then
   read -p "Digite uma mensagem para o commit: " commit_message
   git commit -m "$commit_message"
fi

# Solicitação de confirmação do usuário para fazer push 
read -p "Desaja fazer push das alterações para o repositório remoto? (s/n): " push_changes
if [ "$push_changes" = "s" ]; then
   git push
fi

