<xsl:stylesheet version="1.0"
        
        xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ns0="http://www.starstandard.org/STAR/5">
  <!--<xsl:template match="*">
    <xsl:element name="{local-name()}">
      <xsl:apply-templates select="@* | node()" />
    </xsl:element>
  </xsl:template>
  <xsl:template match="@*">
    <xsl:attribute name="{local-name()}">
      <xsl:value-of select="." />
    </xsl:attribute>
  </xsl:template>-->
  
  <!--<xsl:template match="ns0:OrderQuantity">
    <ns0:OrderQuantity>
      <xsl:value-of select="floor(text())*(text() >= 0) + ceiling(text()) * not(text() >= 0)"/>
    </ns0:OrderQuantity>  
  </xsl:template>
  <xsl:template match="ns0:QuantityShipped">
    <ns0:QuantityShipped>
      <xsl:value-of select="floor(text())*(text() >= 0) + ceiling(text()) * not(text() >= 0)"/>
    </ns0:QuantityShipped>
  </xsl:template>
  <xsl:template match="ns0:UnitPackQuantity">
    <ns0:UnitPackQuantity>
      <xsl:value-of select="floor(text())*(text() >= 0) + ceiling(text()) * not(text() >= 0)"/>
    </ns0:UnitPackQuantity>
  </xsl:template>-->
  <xsl:template match="ns0:OrderQuantity">
    <OrderQuantity>
      <xsl:value-of select="floor(text())*(text() >= 0) + ceiling(text()) * not(text() >= 0)"/>
    </OrderQuantity>  
  </xsl:template>
  <xsl:template match="ns0:QuantityShipped">
    <QuantityShipped>
      <xsl:value-of select="floor(text())*(text() >= 0) + ceiling(text()) * not(text() >= 0)"/>
    </QuantityShipped>
  </xsl:template>
  <xsl:template match="ns0:UnitPackQuantity" >
    <UnitPackQuantity>
      
      <xsl:value-of select="floor(text())*(text() >= 0) + ceiling(text()) * not(text() >= 0)"/>
    </UnitPackQuantity>
  </xsl:template>
  <xsl:template match="*">
    <xsl:element name="{local-name()}">
      <xsl:apply-templates select="@* | node()"/>
    </xsl:element>
  </xsl:template>
  <!--<xsl:template match="node()|@*">
    <xsl:copy>
      <xsl:apply-templates select="node()|@*"/>
    </xsl:copy>
  </xsl:template>
  <xsl:template match="@*[local-name(.)='noNamespaceSchemaLocation']"/>-->
</xsl:stylesheet>