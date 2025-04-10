import os
import glob
from markdownify import markdownify as md

# Encontrar todos os arquivos HTML/HTM no diretório atual
html_files = glob.glob("*.md")
html_files.extend(glob.glob("*.md"))

print(f"Encontrados {len(html_files)} arquivos HTML/HTM para converter")

# Converter cada arquivo para Markdown
for html_file in html_files:
    # Obter nome do arquivo sem extensão
    filename_without_ext = os.path.splitext(html_file)[0]
    md_file = filename_without_ext + ".md"
    
    # Ler o conteúdo HTML
    with open(html_file, 'r', encoding='utf-8') as f:
        html_content = f.read()
    
    # Converter para Markdown
    md_content = md(html_content)
    
    # Salvar o conteúdo Markdown
    with open(md_file, 'w', encoding='utf-8') as f:
        f.write(md_content)
    
    print(f"Convertido: {html_file} -> {md_file}")

print("Conversão concluída!")