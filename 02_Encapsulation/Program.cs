using _02_Encapsulation;

// Encapsulation par défaut dans le namespace : internal
// Encapsulation possible : public ou internal (private n'a pas d'intérêt)

// Encapsulation par défaut dans une classe : private
// Encapsulation possible dans une classe :
// - public
// - private 
// - internal
// - protected
// - protected internal
// - private protected

Personne quentin = new Personne();
quentin.Lastname = "Geerts";
quentin.Firstname = "Quentin";
quentin.Birthdate = new DateTime(1996, 4, 3);

quentin.DireBonjour();
