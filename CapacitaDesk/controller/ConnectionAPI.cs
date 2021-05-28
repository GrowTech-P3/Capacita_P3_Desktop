using CapacitaDesk.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitaDesk.controller
{
    class ConnectionAPI
    {
        /// <summary>
        /// METODO QUE RETORNA UM objResponse DO TIPO StreamReader ATRAVÉS DE ROTA GET
        /// SERIALIZADA
        /// </summary>
        /// <param name="rota"></param>
        /// <returns>objResponse</returns>
        public static Object getLista(String rota, String Token)
        {
            Object objResponse = null;

            try
            {
                // Classe WebRequest: Faz uma solicitaçao para um URL
                var requisicaoWeb = WebRequest.CreateHttp(rota.ToLower());
                requisicaoWeb.Method = "GET";
                requisicaoWeb.Headers.Add("Authorization", "Bearer " + Token);

                //GetResponse: obtem um objeto com a resposta do servidor
                var resposta = requisicaoWeb.GetResponse();

                /* Para que a resposta esteja compativel para ser deserializada devemos:
                 * 1. Obter um stream (fluxo de bytes) as partir dos dados de resposta enviados
                 * 2. Armazenar esta stream como um simples objeto: Classe StreamReade
                 * 3. Ler a informacao deste objeto com metodo ReadToEnd().
                 */

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                objResponse = reader.ReadToEnd();

                resposta.Close();
                reader.Close();

                return objResponse;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao exportar lista: " + err.Message);
                return objResponse;
            }
        }

        /// <summary>
        /// METODO QUE RETORNA UM objResponse DO TIPO StreamReader ATRAVÉS DE ROTA POST
        /// SERIALIZADA
        /// </summary>
        /// <param name="rota"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        public static Object login(String rota, String json)
        {
            Object objResponse = null;

            try
            {
                // Classe WebRequest: Faz uma solicitaçao para um URL
                var requisicaoWeb = WebRequest.CreateHttp(rota.ToLower());
                
                requisicaoWeb.Method = "POST";
                

                // Método ContentType: Define o tipo do conteudo dos dados que serao enviados
                requisicaoWeb.ContentType = "application/json; charset=utf-8";

                // Converter caracteres em um array de bytes
                var byteArray = Encoding.UTF8.GetBytes(json);

                // Atributo ContentLength: Define o tamanho do conteúdo dos dados que serão enviados
                requisicaoWeb.ContentLength = byteArray.Length;

                // Metodo GetRequestStream: retorna um objeto da classe Stream (fluxo de dados)
                // para gravar dados no recurso da internet
                Stream stream = requisicaoWeb.GetRequestStream();

                /* Método Write: Grava um sequencia de bytes no stream atual e
                 * avança a posição atual dentro do stream até o número de bytes gravados
                 * Parâmetros:
                 * 1º) Array de byte que se deseja gravar
                 * 2º) Deslocamento de bytes no qual será iniciado a cópia de bytes
                 * 3º) Número de bytes que serão gravados
                 */
                stream.Write(byteArray, 0, byteArray.Length);
                stream.Close();


                //GetResponse: obtem um objeto com a resposta do servidor
                var resposta = requisicaoWeb.GetResponse();

                /* Para que a resposta esteja compativel para ser deserializada devemos:
                 * 1. Obter um stream (fluxo de bytes) as partir dos dados de resposta enviados
                 * 2. Armazenar esta stream como um simples objeto: Classe StreamReade
                 * 3. Ler a informacao deste objeto com metodo ReadToEnd().
                 */

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                objResponse = reader.ReadToEnd();

                resposta.Close();
                reader.Close();

                return objResponse;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao exportar lista: " + err.Message);
                return objResponse;
            }
        }

        public static Object post(String rota, String json,String Token)
        {
            Object objResponse = null;

            try
            {
                // Classe WebRequest: Faz uma solicitaçao para um URL
                var requisicaoWeb = WebRequest.CreateHttp(rota.ToLower());

                requisicaoWeb.Method = "POST";
                requisicaoWeb.Headers.Add("Authorization", "Bearer " + Token);

                // Método ContentType: Define o tipo do conteudo dos dados que serao enviados
                requisicaoWeb.ContentType = "application/json; charset=utf-8";

                // Converter caracteres em um array de bytes
                var byteArray = Encoding.UTF8.GetBytes(json);

                // Atributo ContentLength: Define o tamanho do conteúdo dos dados que serão enviados
                requisicaoWeb.ContentLength = byteArray.Length;

                // Metodo GetRequestStream: retorna um objeto da classe Stream (fluxo de dados)
                // para gravar dados no recurso da internet
                Stream stream = requisicaoWeb.GetRequestStream();

                /* Método Write: Grava um sequencia de bytes no stream atual e
                 * avança a posição atual dentro do stream até o número de bytes gravados
                 * Parâmetros:
                 * 1º) Array de byte que se deseja gravar
                 * 2º) Deslocamento de bytes no qual será iniciado a cópia de bytes
                 * 3º) Número de bytes que serão gravados
                 */
                stream.Write(byteArray, 0, byteArray.Length);
                stream.Close();


                //GetResponse: obtem um objeto com a resposta do servidor
                var resposta = requisicaoWeb.GetResponse();

                /* Para que a resposta esteja compativel para ser deserializada devemos:
                 * 1. Obter um stream (fluxo de bytes) as partir dos dados de resposta enviados
                 * 2. Armazenar esta stream como um simples objeto: Classe StreamReade
                 * 3. Ler a informacao deste objeto com metodo ReadToEnd().
                 */

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                objResponse = reader.ReadToEnd();

                resposta.Close();
                reader.Close();

                return objResponse;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao exportar lista: " + err.Message);
                return objResponse;
            }
        }
        public static Object remove(String rota, String json, String Token)
        {
            Object objResponse = null;

            try
            {
                // Classe WebRequest: Faz uma solicitaçao para um URL
                var requisicaoWeb = WebRequest.CreateHttp(rota.ToLower());

                requisicaoWeb.Method = "DELETE";
                requisicaoWeb.Headers.Add("Authorization", "Bearer " + Token);

                // Método ContentType: Define o tipo do conteudo dos dados que serao enviados
                requisicaoWeb.ContentType = "application/json; charset=utf-8";

                // Converter caracteres em um array de bytes
                var byteArray = Encoding.UTF8.GetBytes(json);

                // Atributo ContentLength: Define o tamanho do conteúdo dos dados que serão enviados
                requisicaoWeb.ContentLength = byteArray.Length;

                // Metodo GetRequestStream: retorna um objeto da classe Stream (fluxo de dados)
                // para gravar dados no recurso da internet
                Stream stream = requisicaoWeb.GetRequestStream();

                /* Método Write: Grava um sequencia de bytes no stream atual e
                 * avança a posição atual dentro do stream até o número de bytes gravados
                 * Parâmetros:
                 * 1º) Array de byte que se deseja gravar
                 * 2º) Deslocamento de bytes no qual será iniciado a cópia de bytes
                 * 3º) Número de bytes que serão gravados
                 */
                stream.Write(byteArray, 0, byteArray.Length);
                stream.Close();


                //GetResponse: obtem um objeto com a resposta do servidor
                var resposta = requisicaoWeb.GetResponse();

                /* Para que a resposta esteja compativel para ser deserializada devemos:
                 * 1. Obter um stream (fluxo de bytes) as partir dos dados de resposta enviados
                 * 2. Armazenar esta stream como um simples objeto: Classe StreamReade
                 * 3. Ler a informacao deste objeto com metodo ReadToEnd().
                 */

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                objResponse = reader.ReadToEnd();

                resposta.Close();
                reader.Close();

                return objResponse;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao exportar lista: " + err.Message);
                return objResponse;
            }
        }

        public static Object getOne(String rota, String json, String Token)
        {
            Object objResponse = null;

            try
            {
                // Classe WebRequest: Faz uma solicitaçao para um URL
                var requisicaoWeb = WebRequest.CreateHttp(rota.ToLower());
                requisicaoWeb.Method = "GET";
                requisicaoWeb.Headers.Add("Authorization", "Bearer " + Token);

                //GetResponse: obtem um objeto com a resposta do servidor
                var resposta = requisicaoWeb.GetResponse();

                /* Para que a resposta esteja compativel para ser deserializada devemos:
                 * 1. Obter um stream (fluxo de bytes) as partir dos dados de resposta enviados
                 * 2. Armazenar esta stream como um simples objeto: Classe StreamReade
                 * 3. Ler a informacao deste objeto com metodo ReadToEnd().
                 */

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                objResponse = reader.ReadToEnd();

                resposta.Close();
                reader.Close();

                return objResponse;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao exportar lista: " + err.Message);
                return objResponse;
            }
        }
    }
}
