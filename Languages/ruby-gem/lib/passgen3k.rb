class Passgen3k
	def self.test
	 	if(Passgen3k.quick != nil)
	 		return true
	 	else
	 		return false
	 	end
	end

	def self.gen(leng)
		return Passgen3k.gen_c(leng,true,true,true,true)
	end

	def self.gen_c(leng,caps,numb,spec,lowe)
		c = 0
		pass = ""
		while (leng >= c )
			rna = Random.rand(4)
			if(rna == 0 && spec)
				#spec
				rnb = Random.rand(3)
				if(rnb == 0)
					pass += (Random.rand(47-32)+32).chr
				elsif(rnb== 1)
					pass += (Random.rand(64-58)+58).chr
				else
					pass += (Random.rand(126-123)+123).chr
				end
				c+=1
			elsif (rna == 1 && numb)
				#numb
				pass += (Random.rand(57-48)+48).chr
				c+=1
			elsif (rna == 2 && caps)
				#caps
				pass += (Random.rand(90-65)+65).chr
				c+=1
			elsif (rna == 3 && lowe)
				#lowe
				pass += (Random.rand(122-97)+97).chr
				c+=1
			end
		end
		return pass
	end
	def self.quick
		return Passgen3k.gen(8)
	end
end
