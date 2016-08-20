parents(luke, padme, anakin).
parents(leia, padme, anakin).
parents(anakin, shmi, theforce).
parents(sola, jobal, ruwee).
parents(padme, jobal, ruwee).

mother(X, M) :- parents(X, M, F).
father(X, F) :- parents(X, M, F).
parent(X, P) :- mother(X, P).
parent(X, P) :- father(X, P).
grandmother(C, G) :- mother(P, G), parent(C, P).

female(M) :- mother(X, M).
female(sola).
female(leia).

sibling(S1, S2) :- parents(S1, M, F), parents(S2, M, F).
sister(X, S) :- sibling(X, S), female(S).
aunt(C, A) :- parent(X, P), sister(P, A).

?- father(anakin, F).
?- grandmother(X, shmi).
?- sister(luke, S).
?- aunt(leia, A).
