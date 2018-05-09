# CNAM-2018-Projet-SNCF-Server


  <system.serviceModel>
    <services>
      <service behaviorConfiguration="WcfServiceLibrary1.Service1Behavior" name="OuiChatWCF.IService">
        <endpoint address="http://localhost:8080/OuiChatWCF" binding="wsHttpBinding" contract="OuiChatWCF.IService"/>
      </service>
    </services>
    <behaviors>
        <serviceBehaviors>
          <behavior name="WcfServiceLibrary1.Service1Behavior">
            <serviceMetadata httpGetEnabled="true" />
            <serviceDebug includeExceptionDetailInFaults="false" />
          </behavior>
        </serviceBehaviors> 
      </behaviors>
  </system.serviceModel>
    