﻿Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Resources
Imports System.Windows

' Le informazioni generali relative a un assembly sono controllate dal seguente 
' set di attributi. Modificare i valori di questi attributi per modificare le informazioni
' associate a un assembly.

' Controllare i valori degli attributi degli assembly

<Assembly: AssemblyTitle("LSCtrlPasswordWPF")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("LSCtrlPasswordWPF")>
<Assembly: AssemblyCopyright("Copyright @  2019")>
<Assembly: AssemblyTrademark("")> 
<Assembly: ComVisible(false)>

'Per iniziare a creare applicazioni localizzabili, impostare
'<UICulture>CultureYouAreCodingWith</UICulture> nel file VBPROJ
'all'interno di un <PropertyGroup>.  Ad esempio, se si utilizza l'inglese (Stati Uniti)
'nei file di origine, impostare <UICulture> su "en-US".  Rimuovere quindi il commento
'dall'attributo NeutralResourceLanguage seguente.  Aggiornare "en-US" nella riga
'seguente in modo che corrisponda all'impostazione di UICulture nel file di progetto.

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)>


'L'attributo ThemeInfo indica la possibile posizione dei dizionari risorse generici e specifici del tema.
'Primo parametro: posizione dei dizionari risorse specifici del tema
'(da usare se nella pagina non viene trovata una risorsa,
' oppure nei dizionari delle risorse dell'applicazione)

'Parametro 2: posizione del dizionario risorse generico
'(da usare se nella pagina non viene trovata una risorsa,
'un'applicazione e alcun dizionario risorse specifico del tema)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'Se il progetto viene esposto a COM, il GUID seguente verrà usato come ID del typelib
<Assembly: Guid("477fe305-a9a5-4d2d-b18e-5d4e548b5cc7")>

' Le informazioni sulla versione di un assembly sono costituite dai seguenti quattro valori:
'
'      Versione principale
'      Versione secondaria
'      Numero di build
'      Revisione
'
' È possibile specificare tutti i valori oppure impostare valori predefiniti per i numeri relativi alla revisione e alla build
' usando l'asterisco '*' come illustrato di seguito:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("1.0.0.2")>
<Assembly: AssemblyFileVersion("1.0.0.2")>
