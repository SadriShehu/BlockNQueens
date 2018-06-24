# BlockNQueens
Blocked N-Queens
Constraint Satisfaction Problem
Zgjidhja e problemit:
- Caktimi I variablave
- Caktimi I domenit te vlerave per variablat
- Parashikimi I kushtezuar
Zgjidhja:
- Variabla n2
fusha Mij, i=1 deri n, j=1 deri n
- Domeni {-1,0,1} (-1 pozita e bllokuar per tu vendosur mbreteresha, 0- nuk ka mbretereshe ne
ate pozite, 1 –ka mbretereshe ne ate pozite)
- Kushtezimet:
  - Mij = 1 => Mik=0 per çdo k =1 deri n, k<>j
  - Mij = 1 => Mkj=0 per çdo k =1 deri n, k<>i
  - Mij = 1 => Mkp=0 per çdo k =1 deri n, p =1 deri n, k=p dhe k<>I dhe p<>j
  - Mij = 1 nese Mij<>-1
Hapsira e kërkimit
N-Queens ka hapsirë të kërkimit:
𝑛
2
!
(𝑛
2 − 𝑛)! ∗ 𝑛!
8-Queens ka hapsirë të kërkimit :
64!
56! ∗ 8!
= 4,426,165,368
menyra te ndryshme per te vendosur 8 Mbreteresha ne 64 pozita.
Zgjidhje qe permbushin kushtin qe mbretereshat te mos e sulmojn njera tjetren jane 92. Kur ti eliminojm
zgjidhjet që janë të njejta nëse rrotullohen për 90, 180 ose 270 shkallë dhe ato zgjidhjet që janë të
njejta në pasqyrë mbesin gjithsejë 12 zgjidhje unike.
