Gem::Specification.new do |s|
	s.name 		= "passgen3k"
	s.version 	= '0.0.2'
	s.date 		= '2018-01-30'
	s.summary 	= "Password Genorator 3072"
	s.description = "A simple password genorator.\nFunctinos:\ntest - test function\nquick - genorates a 8 char password\ngen(n) - genorate password of n length\ngen_c(n,a,b,c,d) - genorates password of n length with coditions of booleans a, b and c.a - capital letters, b - numbers, c - special characters, d - lower case letters"
	s.files 	= ["lib/passgen3k.rb"]
	s.author 	= ["Haz001"]
	s.homepage	= 'https://github.com/Haz001/PasswordGen3k'
	s.license 	= 'MIT'
end