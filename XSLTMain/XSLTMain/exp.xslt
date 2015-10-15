<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="Businesses">
    <Businesses>
      <xsl:apply-templates/>
    </Businesses>
  </xsl:template>

  <xsl:template match="*">
    <xsl:copy-of select="."/>
  </xsl:template>

  <xsl:template match="Addresses">
    <BusinessAddresses>
      <xsl:apply-templates/>
    </BusinessAddresses>
  </xsl:template>

  <xsl:template match="Addresses/Address">
    <BusinessAddress>
      <xsl:value-of select="."/>
    </BusinessAddress>
  </xsl:template>

</xsl:stylesheet>