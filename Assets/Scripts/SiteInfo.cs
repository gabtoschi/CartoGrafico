using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SiteInfo : MonoBehaviour {

    public Text titleTxt, infoTxt;
    public Image siteImg;
    private string title, siteInfo;
    private Sprite img;
    public void ContinueToRate() {
        SceneManager.LoadScene("TelaVitoria");
    }

    private void Start() {
        switch (PlayerPrefs.GetString("LevelSelected")) {
            case "Salvador":
                title = "Elevador Lacerda";
                img = Resources.Load<Sprite>("Imgs Sites/Elevador Lacerda");
                siteInfo = "O Elevador Lacerda é um dos cartões postais da cidade de Salvador. Inaugurado em 1873, se consolidou como o primeiro elevador do mundo a servir como transporte público, além de ter sido o mais alto desse tipo na época.Ele liga a Praça Tomé de Sousa, na Cidade Alta, à Praça Cayru, na Cidade Baixa.\nFonte: http://www.bahia-turismo.com/salvador/elevador-lacerda.htm";
                break;
            case "Sao Paulo":
                title = "MASP";
                img = Resources.Load<Sprite>("Imgs Sites/Masp");
                siteInfo = "O Museu de Arte de São Paulo é um museu privado sem fins lucrativos, fundado em 1947 pelo empresário Assis Chateaubriand, tornando-se o primeiro museu moderno no país. Está localizado na avenida Paulista o icônico projeto de Lina Bo Bardi, que se tornou um marco na história da arquitetura do século 20, conciliando as superfícies ásperas e sem acabamentos com leveza, transparência e suspensão. A esplanada sob o edifício, conhecida como “vão livre”, foi pensada como uma praça para uso da população. Fonte: https://masp.org.br/sobre ";
                break;
            case "Curitiba":
                title = "Jardim Botânico";
                img = Resources.Load<Sprite>("Imgs Sites/Jardim Botanico icone");
                siteInfo = "O Jardim Botânico de Curitiba, inaugurado em 5 de outubro de 1991, é uma área protegida, constituída por coleções de plantas vivas, cientificamente reconhecidas, organizadas e identificadas, com a finalidade de estudo, pesquisa e documentação do patrimônio florístico do País, em especial da flora paranaense. http://www.curitiba.pr.gov.br/conteudo/jardim-botanico/287 ";
                break;
            case "Belem":
                title = "Theatro da Paz";
                img = Resources.Load<Sprite>("Imgs Sites/teatro da paz icone");
                siteInfo = "Localiza-se na cidade de Belém, no Estado do Pará. Atualmente, é o maior Teatro da Região Norte e um dos mais luxuosos do Brasil. Com cerca de 130 anos de história, é considerado um dos Teatros-Monumentos do País. Foi fundado em 15 de fevereiro de 1878, durante o período áureo do Ciclo da Borracha, quando ocorreu um grande crescimento econômico na região amazônica. http://theatrodapaz.com.br/oTheatro.php ";
                break;
            case "Brasilia":
                title = "Palácio do Planalto";
                img = Resources.Load<Sprite>("Imgs Sites/Palacio do Planalto");
                siteInfo = "O Congresso Nacional é o titular do Poder Legislativo Federal, e o exerce por meio da Câmara dos Deputados e do Senado Federal, cabendo-lhe legislar sobre as matérias de competência da União bem como fiscalizar as entidades da administração direta e indireta, com o auxílio do Tribunal de Contas da União. Fonte: https://www.congressonacional.leg.br/ ";
                break;
            case "Rio de Janeiro":
                title = "Arcos da Lapa";
                img = Resources.Load<Sprite>("Imgs Sites/Arcos da Lapa");
                siteInfo = "O antigo Aqueduto da Carioca, conhecido como Arcos da Lapa, é um dos cartões postais da cidade, além de ser o símbolo mais representativo do Rio Antigo preservado na região boêmia da Lapa. A estrutura, em pedra argamassada, apresenta estilo românico, caiada, possui 42 arcos duplos e óculos na parte superior. Os Arcos da Lapa são considerados a obra arquitetônica de maior porte empreendida no Brasil durante o período colonial. Ao seu redor, estão duas das mais importantes casas de shows da cidade: a Fundição Progresso e o Circo Voador. http://visit.rio/que_fazer/arcosdalapa/ ";
                break;
            case "Rio Branco":
                title = "Palácio Rio Branco";
                img = Resources.Load<Sprite>("Imgs Sites/Palácio rio branco");
                siteInfo = "O Palácio Rio Branco, sede do Governo do Acre, iniciou sua construção na década de 1920, seu projeto arquitetônico foi elaborado pelo arquiteto alemão Alberto Massler, inspirado das edificações gregas com suas colunas de ordem dóricas e jônicas na fachada principal. Inaugurado em 1930, porém, suas obras só foram concluídas no Governo de José Guiomard dos Santos em 1948.Em junho de 2002 foi revitalizado incorporando uma função cultural com exposições que apresentam as diversas fases da história do povo acreano por intermédio de textos, objetos históricos, fotografias e depoimentos. Considerado o maior projeto arquitetônico do Acre, teve seu processo de tombamento concluído em dezembro de 2005.Em 13 de junho de 2008 foi instituído oficialmente pelo Governador Binho Marques, Museu Palácio Rio Branco. No pátio do Palácio, podemos contemplar o Obelisco dos Heróis da Revolução, construído da década de 1930, em homenagem aos combatentes da Revolução Acreana e a fonte da sagração, popularmente conhecida como luminosa, construída em 25 de julho de 1948, em homenagem ao primeiro Bispo do Acre Dom Julio Matioli.\n http://www.ac.gov.br";
                break;
        }
        infoTxt.text = siteInfo;
        titleTxt.text = title;
        siteImg.sprite = img;
        siteImg.preserveAspect = true;
    }
}
