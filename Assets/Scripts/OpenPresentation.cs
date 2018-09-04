using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenPresentation : MonoBehaviour {


    public Text cityPanel, sitePanel,titlePanel;
    private string cityInfo, siteInfo, title;
    private void Start() {
        PopulatePanel();
    }
    private void PopulatePanel() {
        switch (PlayerPrefs.GetString("LevelSelected")) {
            case "Salvador":
                title = "Salvador";
                cityInfo = "Sobre a cidade: \n\tEm 2001 completou-se 500 anos desde que os primeiros europeus caminharam pelas terras da atual cidade de Salvador. A cidade mais antiga do Brasil e primeira capital do país chega, atualmente, aos três milhões de habitantes e se consolida como um dos pólos turísticos brasileiros, tanto pela sua vasta diversidade cultural quanto pelas belezas naturais.\n\t\tFonte: http://www.cidade-salvador.com/";
                siteInfo = "Elevador Lacerda: \n\tO Elevador Lacerda é um dos cartões postais da cidade de Salvador. Inaugurado em 1873, se consolidou como o primeiro elevador do mundo a servir como transporte público, além de ter sido o mais alto desse tipo na época.Ele liga a Praça Tomé de Sousa, na Cidade Alta, à Praça Cayru, na Cidade Baixa.\n\t\tFonte: http://www.bahia-turismo.com/salvador/elevador-lacerda.htm";
                break;
            case "Sao Paulo":
                title = "São Paulo";
                cityInfo = "Sobre a cidade:\n\tSão Paulo recebeu seus primeiros habitantes europeus nas primeiras décadas do século 16. A grande expansão demográfica e econômica, entretanto, aconteceu apenas a partir do final do século 19, com a chegada de imigrantes de outras partes do Brasil e do exterior. Hoje é o estado brasileiro com a maior economia e o maior parque industrial.\n\t\tFonte: http://www.sp-turismo.com/";
                siteInfo = "MASP: \n\tO Museu de Arte de São Paulo é um museu privado sem fins lucrativos, fundado em 1947 pelo empresário e mecenas Assis Chateaubriand (1892 - 1968), tornando-se o primeiro museu moderno no país. O museu está localizado na avenida Paulista no icônico projeto de Lina Bo Bardi, que se tornou um marco na história da arquitetura do século 20 que concilia em sua arquitetura as superfícies ásperas e sem acabamentos com leveza, transparência e suspensão. A esplanada sob o edifício, conhecida como “vão livre”, foi pensada como uma praça para uso da população.\n\t\tFonte: https://masp.org.br/sobre";
                break;
            case "Curitiba":
                title = "Curitiba";
                cityInfo = "Sobre a cidade:\n\tCuritiba é a capital do Paraná, um dos três Estados que compõem a Região Sul do Brasil. Sua fundação oficial data de 29 de março de 1693, quando foi criada a Câmara.\n\t\tFonte: http://www.curitiba.pr.gov.br/conteudo/perfil-da-cidade-de-curitiba/174";
                siteInfo = "Jardim Botânico: \n\tO Jardim Botânico de Curitiba, inaugurado em 5 de outubro de 1991, é uma área protegida, constituída por coleções de plantas vivas, cientificamente reconhecidas, organizadas e identificadas, com a finalidade de estudo, pesquisa e documentação do patrimônio florístico do País, em especial da flora paranaense.\n\t\tFonte: http://www.curitiba.pr.gov.br/conteudo/jardim-botanico/287 ";
                break;
            case "Belem":
                title = "Belém";
                cityInfo = "Sobre a cidade:\n\tCapital do estado do Pará, exerce significativa influência nacional, seja do ponto de vista cultural, gastronômico econômico ou político. Conta com importantes monumentos, parques e museus, como o Theatro da Paz, o Museu Paraense Emílio Goeldi, o mercado do Ver-o-Peso, e eventos de grande repercussão, como o Círio de Nazaré.\n\t\tFonte: http://www.belem.pa.gov.br/ ";
                siteInfo = "Theatro da Paz: \n\tLocaliza-se na cidade de Belém, no Estado do Pará. Atualmente, é o maior Teatro da Região Norte e um dos mais luxuosos do Brasil. Com cerca de 130 anos de história, é considerado um dos Teatros-Monumentos do País.Foi fundado em 15 de fevereiro de 1878, durante o período áureo do Ciclo da Borracha, quando ocorreu um grande crescimento econômico na região amazônica.\n\t\tFonte: http://theatrodapaz.com.br/oTheatro.php ";
                break;
            case "Brasilia":
                title = "Brasília";
                cityInfo = "Sobre a cidade:\n\tBrasília, a cidade sonho. No governo de Juscelino Kubitschek, em 21 de abril de 1960, Brasília nascia para o mundo e para a sua gente. Com os projetos urbanístico de Lúcio Costa e o arquitetônico de Oscar Niemeyer, surgia uma cidade sob formas inovadoras, diferente de tudo já feito até então.\n\t\tFonte: http://www.df.gov.br/historia/";
                siteInfo = "Congresso Nacional:\n\tO Congresso Nacional é o titular do Poder Legislativo Federal, e o exerce por meio da Câmara dos Deputados e do Senado Federal, cabendo-lhe legislar sobre as matérias de competência da União bem como fiscalizar as entidades da administração direta e indireta, com o auxílio do Tribunal de Contas da União.\n\t\tFonte: https://www.congressonacional.leg.br/ ";
                break;
            case "Rio de Janeiro":
                title = "Rio de Janeiro";
                cityInfo = "Sobre a cidade:\n\tPelos idos do século XV, dispondo da avançada tecnologia da época, povos da Europa Ocidental lançaram suas embarcações pelas revoltas águas atlânticas – fato conhecido como Grandes Navegações. Nessa era, tida como a Era dos Descobrimentos, a cidade de São Sebastião do Rio de Janeiro entra na História quando caravelas portuguesas alcançaram pela primeira vez a região, com a expedição de 1501, comandada provavelmente por Gaspar de Lemos. Singrando as águas do Mar Sem Fim, margeando o litoral ainda desconhecido da América portuguesa, em 1º de janeiro de 1502 a tripulação se deparou com o que Américo Vespúcio(1454 - 1512) descreveu como um “grande espelho d’água, com entrada estreita e bem protegida”: a Baía de Guanabara. Décadas depois, nas terras do seu entorno, em meio às batalhas sangrentas para retomar a região ocupada por franceses, no dia 1º de março de 1565 seria fundada a cidade, sob a invocação de São Sebastião, padroeiro do rei de Portugal, D.Sebastião.\n\t\tFonte: http://multirio.rio.rj.gov.br/index.php/estude/historia-do-brasil/rio-de-janeiro/2387-introducao ";
                siteInfo = "Arcos da Lapa: \n\tO antigo Aqueduto da Carioca, conhecido como Arcos da Lapa, é um dos cartões postais da cidade, além de ser o símbolo mais representativo do Rio Antigo preservado na região boêmia da Lapa.A estrutura, em pedra argamassada, apresenta estilo românico, caiada, possui 42 arcos duplos e óculos na parte superior.Os Arcos da Lapa são considerados a obra arquitetônica de maior porte empreendida no Brasil durante o período colonial.Ao seu redor, estão duas das mais importantes casas de shows da cidade: a Fundição Progresso e o Circo Voador.\n\t\tFonte: http://visit.rio/que_fazer/arcosdalapa/ ";
                break;
            case "Rio Branco":
                title = "Rio Branco";
                cityInfo = "Sobre a cidade:\nRio Branco não é uma cidade qualquer. Além de ser o mais antigo núcleo urbano do Acre, logo se constituiu como a maior e mais importante cidade acreana sendo por isso escolhida como a capital do antigo Território Federal e do Estado do Acre.Mas Rio Branco ainda aguarda a elaboração de pesquisas e a organização de sua história com a abrangência e importância que de fato possui para a configuração da sociedade acreana.\n\t\tFonte: http://www.riobranco.ac.gov.br/index.php/rio-branco";
                siteInfo = "Palácio Rio Branco:\n\tO Palácio Rio Branco, sede do Governo do Acre, iniciou sua construção na década de 1920, seu projeto arquitetônico foi elaborado pelo arquiteto alemão Alberto Massler, inspirado das edificações gregas com suas colunas de ordem dóricas e jônicas na fachada principal. Inaugurado em 1930, porém, suas obras só foram concluídas no Governo de José Guiomard dos Santos em 1948.Em junho de 2002 foi revitalizado incorporando uma função cultural com exposições que apresentam as diversas fases da história do povo acreano por intermédio de textos, objetos históricos, fotografias e depoimentos. Considerado o maior projeto arquitetônico do Acre, teve seu processo de tombamento concluído em dezembro de 2005.Em 13 de junho de 2008 foi instituído oficialmente pelo Governador Binho Marques, Museu Palácio Rio Branco. No pátio do Palácio, podemos contemplar o Obelisco dos Heróis da Revolução, construído da década de 1930, em homenagem aos combatentes da Revolução Acreana e a fonte da sagração, popularmente conhecida como luminosa, construída em 25 de julho de 1948, em homenagem ao primeiro Bispo do Acre Dom Julio Matioli.\n\t\tFonte:  http://www.ac.gov.br";
                break;
        }
        titlePanel.text = "Bem-vindo a "+title;
        cityPanel.text = cityInfo;
        sitePanel.text = siteInfo;
    }
	
	public void OpenLevel() {
        SceneManager.LoadScene(PlayerPrefs.GetString("LevelSelected"));
    }
}
