using System;

[Serializable]
public class User
{
    public string id;
    public string name;
    public string dateOfBirth;
    public string days;
    public string sex;
    public string weight;
    public bool authorized;
    public string cpf;
    public string namePerson;
    public string city;

    public User(int id, string nome, string dataNascimento, int dias, string sexo, bool autorizado, long cpf, float peso, string nomeResponsavel, string cidade)
    {
        this.id = "Id: "+ id;
        this.name = "Nome: "+ nome;
        this.dateOfBirth = "Data Nascimento: "+dataNascimento;
        this.days = "Dias: "+ dias;
        this.sex = "Sexo: "+ sexo;
        this.authorized = autorizado;
        this.cpf = "Cpf: "+ cpf;
        this.weight = "Peso: "+ peso;
        this.namePerson = "Nome Responsável: "+nomeResponsavel;
        this.city = "Cidade: "+ cidade;
    }
}
