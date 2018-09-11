using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenPresentation : MonoBehaviour {


    public Text cityPanel,titlePanel;
    private string cityInfo, title;

    private void Start() {
        PopulatePanel();
    }
    private void PopulatePanel() {
        //Populates City info text and Site info text according to level
        switch (PlayerPrefs.GetString("LevelSelected")) {
            case "Salvador":
                title = "Salvador";
                cityInfo = "Informações sobre a cidade: \n Em 2001 completou - se 500 anos desde que os primeiros europeus caminharam pelas terras da atual cidade de Salvador. A cidade mais antiga do Brasil e primeira capital do país chega, atualmente, aos três milhões de habitantes e se consolida como um dos pólos turísticos brasileiros, tanto pela sua vasta diversidade cultural quanto pelas belezas naturais.\nFonte: http://www.cidade-salvador.com/";
                break;
            case "Sao Paulo":
                title = "São Paulo";
                cityInfo = "Informações sobre a cidade:\nSão Paulo recebeu seus primeiros habitantes europeus nas primeiras décadas do século 16.A grande expansão demográfica e econômica, entretanto, aconteceu apenas a partir do final do século 19, com a chegada de imigrantes de outras partes do Brasil e do exterior.Hoje é o estado brasileiro com a maior economia e o maior parque industrial. nFonte: http://www.sp-turismo.com/";
                break;
            case "Curitiba":
                title = "Curitiba";
                cityInfo = "Informações sobre a cidade:\nCuritiba é a capital do Paraná, um dos três Estados que compõem a Região Sul do Brasil.Sua fundação oficial data de 29 de março de 1693, quando foi criada a Câmara.\n http://www.curitiba.pr.gov.br/conteudo/perfil-da-cidade-de-curitiba/174";
                break;
            case "Belem":
                title = "Belém";
                cityInfo = "Informações sobre a cidade:\nCapital do estado do Pará, Exerce significativa influência nacional, seja do ponto de vista cultural, gastronômico econômico ou político. Conta com importantes monumentos, parques e museus, como o Theatro da Paz, o Museu Paraense Emílio Goeldi, o mercado do Ver - o - Peso, e eventos de grande repercussão, como o Círio de Nazaré.\n http://www.belem.pa.gov.br/ ";
                break;
            case "Brasilia":
                title = "Brasília";
                cityInfo = "Informações sobre a cidade:\nBrasília, a cidade sonho.No governo de Juscelino Kubitschek, em 21 de abril de 1960, Brasília nascia para o mundo e para a sua gente. Com os projetos urbanístico de Lúcio Costa e o arquitetônico de Oscar Niemeyer, surgia uma cidade sob formas inovadoras, diferente de tudo já feito até então. \nFonte: http://www.df.gov.br/historia/";
                break;
            case "Rio de Janeiro":
                title = "Rio de Janeiro";
                cityInfo = "Informações sobre a cidade:\nPelos idos do século XV, dispondo da avançada tecnologia da época, povos da Europa Ocidental lançaram suas embarcações pelas revoltas águas atlânticas – fato conhecido como Grandes Navegações.Nessa era, tida como a Era dos Descobrimentos, a cidade de São Sebastião do Rio de Janeiro entra na História quando caravelas portuguesas alcançaram pela primeira vez a região, com a expedição de 1501, comandada provavelmente por Gaspar de Lemos. Singrando as águas do Mar Sem Fim, margeando o litoral ainda desconhecido da América portuguesa, em 1º de janeiro de 1502 a tripulação se deparou com o que Américo Vespúcio(1454 - 1512) descreveu como um “grande espelho d’água, com entrada estreita e bem protegida”: a Baía de Guanabara. Décadas depois, nas terras do seu entorno, em meio às batalhas sangrentas para retomar a região ocupada por franceses, no dia 1º de março de 1565 seria fundada a cidade, sob a invocação de São Sebastião, padroeiro do rei de Portugal, D.Sebastião.\n http://multirio.rio.rj.gov.br/index.php/estude/historia-do-brasil/rio-de-janeiro/2387-introducao ";
                break;
            case "Rio Branco":
                title = "Rio Branco";
                cityInfo = "Informações sobre a cidade:\nRio Branco não é uma cidade qualquer.Além de ser o mais antigo núcleo urbano do Acre, logo se constituiu como a maior e mais importante cidade acreana sendo por isso escolhida como a capital do antigo Território Federal e do Estado do Acre.Mas Rio Branco ainda aguarda a elaboração de pesquisas e a organização de sua história com a abrangência e importância que de fato possui para a configuração da sociedade acreana.\n http://www.riobranco.ac.gov.br/index.php/rio-branco";
                break;
        }
        titlePanel.text = "Bem-vindo a "+title;
        cityPanel.text = cityInfo;
    }
	
	public void OpenLevel() {
        SceneManager.LoadScene(PlayerPrefs.GetString("LevelSelected"));
    }
}
