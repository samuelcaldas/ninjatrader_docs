import glob
import re

odd_files = []
for f in sorted(glob.glob("*.md")):
    c = open(f, errors='ignore').read()
    fences = len(re.findall(r"^```", c, re.MULTILINE))
    if fences % 2 != 0:
        odd_files.append(f)

for f in odd_files:
    print(f"=== {f} ===")
    c = open(f, errors='ignore').read()
    lines = c.split('\n')
    for i, line in enumerate(lines):
        if line.startswith('```'):
            print(f"  Line {i+1}: {line}")
            # print surrounding 2 lines
            for j in range(max(0, i-1), min(len(lines), i+2)):
                print(f"    [{j+1}] {lines[j]}")
