Pizza robot
=============================
Pizza delivery robot. The robot starts its movement at the point (0, 0) of the rectangular coordinate system 
and can perform the following actions:

- N (Move North) - move up
- S (Move South) - move down
- E (Move East) - move right
- W (Move West) - move left
- D (Drop pizza)

The robot reads from the standard input (stdin) a line:

5x5 (1, 3) (4, 4)

For the line above, the result might be:
ENNNDEEEND


QUICK START
-----------
```no-highlight
 Ubuntu (docker)
 A. Run an ubuntu docker container
	docker run -it ubuntu
 B. Clone the project from github
	apt install -y git
	git clone <url> /project
 C. Setup execution environment
	sh /project/prepare.sh
 D. Run the project
	cd /project/PizzaBot
	dotnet run
