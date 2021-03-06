namespace QuickFix42
{

  public class QuoteAcknowledgement : Message
  {
    public QuoteAcknowledgement() : base(MsgType()) {}
    static QuickFix.MsgType MsgType() { return new QuickFix.MsgType("b"); }

    public QuoteAcknowledgement(
      QuickFix.QuoteAckStatus aQuoteAckStatus )
    : base(MsgType()) {
      set(aQuoteAckStatus);
    }

    public void set(QuickFix.QuoteReqID value)
    { setField(value); }
    public QuickFix.QuoteReqID get(QuickFix.QuoteReqID  value)
    { getField(value); return value; }
    public QuickFix.QuoteReqID getQuoteReqID()
    { QuickFix.QuoteReqID value = new QuickFix.QuoteReqID();
      getField(value); return value; }
    public bool isSet(QuickFix.QuoteReqID field)
    { return isSetField(field); }
    public bool isSetQuoteReqID()
    { return isSetField(131); }

    public void set(QuickFix.QuoteID value)
    { setField(value); }
    public QuickFix.QuoteID get(QuickFix.QuoteID  value)
    { getField(value); return value; }
    public QuickFix.QuoteID getQuoteID()
    { QuickFix.QuoteID value = new QuickFix.QuoteID();
      getField(value); return value; }
    public bool isSet(QuickFix.QuoteID field)
    { return isSetField(field); }
    public bool isSetQuoteID()
    { return isSetField(117); }

    public void set(QuickFix.QuoteAckStatus value)
    { setField(value); }
    public QuickFix.QuoteAckStatus get(QuickFix.QuoteAckStatus  value)
    { getField(value); return value; }
    public QuickFix.QuoteAckStatus getQuoteAckStatus()
    { QuickFix.QuoteAckStatus value = new QuickFix.QuoteAckStatus();
      getField(value); return value; }
    public bool isSet(QuickFix.QuoteAckStatus field)
    { return isSetField(field); }
    public bool isSetQuoteAckStatus()
    { return isSetField(297); }

    public void set(QuickFix.QuoteRejectReason value)
    { setField(value); }
    public QuickFix.QuoteRejectReason get(QuickFix.QuoteRejectReason  value)
    { getField(value); return value; }
    public QuickFix.QuoteRejectReason getQuoteRejectReason()
    { QuickFix.QuoteRejectReason value = new QuickFix.QuoteRejectReason();
      getField(value); return value; }
    public bool isSet(QuickFix.QuoteRejectReason field)
    { return isSetField(field); }
    public bool isSetQuoteRejectReason()
    { return isSetField(300); }

    public void set(QuickFix.QuoteResponseLevel value)
    { setField(value); }
    public QuickFix.QuoteResponseLevel get(QuickFix.QuoteResponseLevel  value)
    { getField(value); return value; }
    public QuickFix.QuoteResponseLevel getQuoteResponseLevel()
    { QuickFix.QuoteResponseLevel value = new QuickFix.QuoteResponseLevel();
      getField(value); return value; }
    public bool isSet(QuickFix.QuoteResponseLevel field)
    { return isSetField(field); }
    public bool isSetQuoteResponseLevel()
    { return isSetField(301); }

    public void set(QuickFix.TradingSessionID value)
    { setField(value); }
    public QuickFix.TradingSessionID get(QuickFix.TradingSessionID  value)
    { getField(value); return value; }
    public QuickFix.TradingSessionID getTradingSessionID()
    { QuickFix.TradingSessionID value = new QuickFix.TradingSessionID();
      getField(value); return value; }
    public bool isSet(QuickFix.TradingSessionID field)
    { return isSetField(field); }
    public bool isSetTradingSessionID()
    { return isSetField(336); }

    public void set(QuickFix.Text value)
    { setField(value); }
    public QuickFix.Text get(QuickFix.Text  value)
    { getField(value); return value; }
    public QuickFix.Text getText()
    { QuickFix.Text value = new QuickFix.Text();
      getField(value); return value; }
    public bool isSet(QuickFix.Text field)
    { return isSetField(field); }
    public bool isSetText()
    { return isSetField(58); }

    public void set(QuickFix.NoQuoteSets value)
    { setField(value); }
    public QuickFix.NoQuoteSets get(QuickFix.NoQuoteSets  value)
    { getField(value); return value; }
    public QuickFix.NoQuoteSets getNoQuoteSets()
    { QuickFix.NoQuoteSets value = new QuickFix.NoQuoteSets();
      getField(value); return value; }
    public bool isSet(QuickFix.NoQuoteSets field)
    { return isSetField(field); }
    public bool isSetNoQuoteSets()
    { return isSetField(296); }

    public class NoQuoteSets: QuickFix.Group
    {
    public NoQuoteSets() : base(296,302,message_order ) {}
    static int[] message_order = new int[] {302,311,312,309,305,310,313,314,315,316,317,436,435,308,306,362,363,307,364,365,304,295,0};
      public void set(QuickFix.QuoteSetID value)
      { setField(value); }
      public QuickFix.QuoteSetID get(QuickFix.QuoteSetID  value)
      { getField(value); return value; }
      public QuickFix.QuoteSetID getQuoteSetID()
      { QuickFix.QuoteSetID value = new QuickFix.QuoteSetID();
        getField(value); return value; }
      public bool isSet(QuickFix.QuoteSetID field)
      { return isSetField(field); }
      public bool isSetQuoteSetID()
      { return isSetField(302); }

      public void set(QuickFix.UnderlyingSymbol value)
      { setField(value); }
      public QuickFix.UnderlyingSymbol get(QuickFix.UnderlyingSymbol  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingSymbol getUnderlyingSymbol()
      { QuickFix.UnderlyingSymbol value = new QuickFix.UnderlyingSymbol();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingSymbol field)
      { return isSetField(field); }
      public bool isSetUnderlyingSymbol()
      { return isSetField(311); }

      public void set(QuickFix.UnderlyingSymbolSfx value)
      { setField(value); }
      public QuickFix.UnderlyingSymbolSfx get(QuickFix.UnderlyingSymbolSfx  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingSymbolSfx getUnderlyingSymbolSfx()
      { QuickFix.UnderlyingSymbolSfx value = new QuickFix.UnderlyingSymbolSfx();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingSymbolSfx field)
      { return isSetField(field); }
      public bool isSetUnderlyingSymbolSfx()
      { return isSetField(312); }

      public void set(QuickFix.UnderlyingSecurityID value)
      { setField(value); }
      public QuickFix.UnderlyingSecurityID get(QuickFix.UnderlyingSecurityID  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingSecurityID getUnderlyingSecurityID()
      { QuickFix.UnderlyingSecurityID value = new QuickFix.UnderlyingSecurityID();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingSecurityID field)
      { return isSetField(field); }
      public bool isSetUnderlyingSecurityID()
      { return isSetField(309); }

      public void set(QuickFix.UnderlyingIDSource value)
      { setField(value); }
      public QuickFix.UnderlyingIDSource get(QuickFix.UnderlyingIDSource  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingIDSource getUnderlyingIDSource()
      { QuickFix.UnderlyingIDSource value = new QuickFix.UnderlyingIDSource();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingIDSource field)
      { return isSetField(field); }
      public bool isSetUnderlyingIDSource()
      { return isSetField(305); }

      public void set(QuickFix.UnderlyingSecurityType value)
      { setField(value); }
      public QuickFix.UnderlyingSecurityType get(QuickFix.UnderlyingSecurityType  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingSecurityType getUnderlyingSecurityType()
      { QuickFix.UnderlyingSecurityType value = new QuickFix.UnderlyingSecurityType();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingSecurityType field)
      { return isSetField(field); }
      public bool isSetUnderlyingSecurityType()
      { return isSetField(310); }

      public void set(QuickFix.UnderlyingMaturityMonthYear value)
      { setField(value); }
      public QuickFix.UnderlyingMaturityMonthYear get(QuickFix.UnderlyingMaturityMonthYear  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingMaturityMonthYear getUnderlyingMaturityMonthYear()
      { QuickFix.UnderlyingMaturityMonthYear value = new QuickFix.UnderlyingMaturityMonthYear();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingMaturityMonthYear field)
      { return isSetField(field); }
      public bool isSetUnderlyingMaturityMonthYear()
      { return isSetField(313); }

      public void set(QuickFix.UnderlyingMaturityDay value)
      { setField(value); }
      public QuickFix.UnderlyingMaturityDay get(QuickFix.UnderlyingMaturityDay  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingMaturityDay getUnderlyingMaturityDay()
      { QuickFix.UnderlyingMaturityDay value = new QuickFix.UnderlyingMaturityDay();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingMaturityDay field)
      { return isSetField(field); }
      public bool isSetUnderlyingMaturityDay()
      { return isSetField(314); }

      public void set(QuickFix.UnderlyingPutOrCall value)
      { setField(value); }
      public QuickFix.UnderlyingPutOrCall get(QuickFix.UnderlyingPutOrCall  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingPutOrCall getUnderlyingPutOrCall()
      { QuickFix.UnderlyingPutOrCall value = new QuickFix.UnderlyingPutOrCall();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingPutOrCall field)
      { return isSetField(field); }
      public bool isSetUnderlyingPutOrCall()
      { return isSetField(315); }

      public void set(QuickFix.UnderlyingStrikePrice value)
      { setField(value); }
      public QuickFix.UnderlyingStrikePrice get(QuickFix.UnderlyingStrikePrice  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingStrikePrice getUnderlyingStrikePrice()
      { QuickFix.UnderlyingStrikePrice value = new QuickFix.UnderlyingStrikePrice();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingStrikePrice field)
      { return isSetField(field); }
      public bool isSetUnderlyingStrikePrice()
      { return isSetField(316); }

      public void set(QuickFix.UnderlyingOptAttribute value)
      { setField(value); }
      public QuickFix.UnderlyingOptAttribute get(QuickFix.UnderlyingOptAttribute  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingOptAttribute getUnderlyingOptAttribute()
      { QuickFix.UnderlyingOptAttribute value = new QuickFix.UnderlyingOptAttribute();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingOptAttribute field)
      { return isSetField(field); }
      public bool isSetUnderlyingOptAttribute()
      { return isSetField(317); }

      public void set(QuickFix.UnderlyingContractMultiplier value)
      { setField(value); }
      public QuickFix.UnderlyingContractMultiplier get(QuickFix.UnderlyingContractMultiplier  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingContractMultiplier getUnderlyingContractMultiplier()
      { QuickFix.UnderlyingContractMultiplier value = new QuickFix.UnderlyingContractMultiplier();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingContractMultiplier field)
      { return isSetField(field); }
      public bool isSetUnderlyingContractMultiplier()
      { return isSetField(436); }

      public void set(QuickFix.UnderlyingCouponRate value)
      { setField(value); }
      public QuickFix.UnderlyingCouponRate get(QuickFix.UnderlyingCouponRate  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingCouponRate getUnderlyingCouponRate()
      { QuickFix.UnderlyingCouponRate value = new QuickFix.UnderlyingCouponRate();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingCouponRate field)
      { return isSetField(field); }
      public bool isSetUnderlyingCouponRate()
      { return isSetField(435); }

      public void set(QuickFix.UnderlyingSecurityExchange value)
      { setField(value); }
      public QuickFix.UnderlyingSecurityExchange get(QuickFix.UnderlyingSecurityExchange  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingSecurityExchange getUnderlyingSecurityExchange()
      { QuickFix.UnderlyingSecurityExchange value = new QuickFix.UnderlyingSecurityExchange();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingSecurityExchange field)
      { return isSetField(field); }
      public bool isSetUnderlyingSecurityExchange()
      { return isSetField(308); }

      public void set(QuickFix.UnderlyingIssuer value)
      { setField(value); }
      public QuickFix.UnderlyingIssuer get(QuickFix.UnderlyingIssuer  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingIssuer getUnderlyingIssuer()
      { QuickFix.UnderlyingIssuer value = new QuickFix.UnderlyingIssuer();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingIssuer field)
      { return isSetField(field); }
      public bool isSetUnderlyingIssuer()
      { return isSetField(306); }

      public void set(QuickFix.EncodedUnderlyingIssuerLen value)
      { setField(value); }
      public QuickFix.EncodedUnderlyingIssuerLen get(QuickFix.EncodedUnderlyingIssuerLen  value)
      { getField(value); return value; }
      public QuickFix.EncodedUnderlyingIssuerLen getEncodedUnderlyingIssuerLen()
      { QuickFix.EncodedUnderlyingIssuerLen value = new QuickFix.EncodedUnderlyingIssuerLen();
        getField(value); return value; }
      public bool isSet(QuickFix.EncodedUnderlyingIssuerLen field)
      { return isSetField(field); }
      public bool isSetEncodedUnderlyingIssuerLen()
      { return isSetField(362); }

      public void set(QuickFix.EncodedUnderlyingIssuer value)
      { setField(value); }
      public QuickFix.EncodedUnderlyingIssuer get(QuickFix.EncodedUnderlyingIssuer  value)
      { getField(value); return value; }
      public QuickFix.EncodedUnderlyingIssuer getEncodedUnderlyingIssuer()
      { QuickFix.EncodedUnderlyingIssuer value = new QuickFix.EncodedUnderlyingIssuer();
        getField(value); return value; }
      public bool isSet(QuickFix.EncodedUnderlyingIssuer field)
      { return isSetField(field); }
      public bool isSetEncodedUnderlyingIssuer()
      { return isSetField(363); }

      public void set(QuickFix.UnderlyingSecurityDesc value)
      { setField(value); }
      public QuickFix.UnderlyingSecurityDesc get(QuickFix.UnderlyingSecurityDesc  value)
      { getField(value); return value; }
      public QuickFix.UnderlyingSecurityDesc getUnderlyingSecurityDesc()
      { QuickFix.UnderlyingSecurityDesc value = new QuickFix.UnderlyingSecurityDesc();
        getField(value); return value; }
      public bool isSet(QuickFix.UnderlyingSecurityDesc field)
      { return isSetField(field); }
      public bool isSetUnderlyingSecurityDesc()
      { return isSetField(307); }

      public void set(QuickFix.EncodedUnderlyingSecurityDescLen value)
      { setField(value); }
      public QuickFix.EncodedUnderlyingSecurityDescLen get(QuickFix.EncodedUnderlyingSecurityDescLen  value)
      { getField(value); return value; }
      public QuickFix.EncodedUnderlyingSecurityDescLen getEncodedUnderlyingSecurityDescLen()
      { QuickFix.EncodedUnderlyingSecurityDescLen value = new QuickFix.EncodedUnderlyingSecurityDescLen();
        getField(value); return value; }
      public bool isSet(QuickFix.EncodedUnderlyingSecurityDescLen field)
      { return isSetField(field); }
      public bool isSetEncodedUnderlyingSecurityDescLen()
      { return isSetField(364); }

      public void set(QuickFix.EncodedUnderlyingSecurityDesc value)
      { setField(value); }
      public QuickFix.EncodedUnderlyingSecurityDesc get(QuickFix.EncodedUnderlyingSecurityDesc  value)
      { getField(value); return value; }
      public QuickFix.EncodedUnderlyingSecurityDesc getEncodedUnderlyingSecurityDesc()
      { QuickFix.EncodedUnderlyingSecurityDesc value = new QuickFix.EncodedUnderlyingSecurityDesc();
        getField(value); return value; }
      public bool isSet(QuickFix.EncodedUnderlyingSecurityDesc field)
      { return isSetField(field); }
      public bool isSetEncodedUnderlyingSecurityDesc()
      { return isSetField(365); }

      public void set(QuickFix.TotQuoteEntries value)
      { setField(value); }
      public QuickFix.TotQuoteEntries get(QuickFix.TotQuoteEntries  value)
      { getField(value); return value; }
      public QuickFix.TotQuoteEntries getTotQuoteEntries()
      { QuickFix.TotQuoteEntries value = new QuickFix.TotQuoteEntries();
        getField(value); return value; }
      public bool isSet(QuickFix.TotQuoteEntries field)
      { return isSetField(field); }
      public bool isSetTotQuoteEntries()
      { return isSetField(304); }

      public void set(QuickFix.NoQuoteEntries value)
      { setField(value); }
      public QuickFix.NoQuoteEntries get(QuickFix.NoQuoteEntries  value)
      { getField(value); return value; }
      public QuickFix.NoQuoteEntries getNoQuoteEntries()
      { QuickFix.NoQuoteEntries value = new QuickFix.NoQuoteEntries();
        getField(value); return value; }
      public bool isSet(QuickFix.NoQuoteEntries field)
      { return isSetField(field); }
      public bool isSetNoQuoteEntries()
      { return isSetField(295); }

      public class NoQuoteEntries: QuickFix.Group
      {
      public NoQuoteEntries() : base(295,299,message_order ) {}
      static int[] message_order = new int[] {299,55,65,48,22,167,200,205,201,202,206,231,223,207,106,348,349,107,350,351,368,0};
        public void set(QuickFix.QuoteEntryID value)
        { setField(value); }
        public QuickFix.QuoteEntryID get(QuickFix.QuoteEntryID  value)
        { getField(value); return value; }
        public QuickFix.QuoteEntryID getQuoteEntryID()
        { QuickFix.QuoteEntryID value = new QuickFix.QuoteEntryID();
          getField(value); return value; }
        public bool isSet(QuickFix.QuoteEntryID field)
        { return isSetField(field); }
        public bool isSetQuoteEntryID()
        { return isSetField(299); }

        public void set(QuickFix.Symbol value)
        { setField(value); }
        public QuickFix.Symbol get(QuickFix.Symbol  value)
        { getField(value); return value; }
        public QuickFix.Symbol getSymbol()
        { QuickFix.Symbol value = new QuickFix.Symbol();
          getField(value); return value; }
        public bool isSet(QuickFix.Symbol field)
        { return isSetField(field); }
        public bool isSetSymbol()
        { return isSetField(55); }

        public void set(QuickFix.SymbolSfx value)
        { setField(value); }
        public QuickFix.SymbolSfx get(QuickFix.SymbolSfx  value)
        { getField(value); return value; }
        public QuickFix.SymbolSfx getSymbolSfx()
        { QuickFix.SymbolSfx value = new QuickFix.SymbolSfx();
          getField(value); return value; }
        public bool isSet(QuickFix.SymbolSfx field)
        { return isSetField(field); }
        public bool isSetSymbolSfx()
        { return isSetField(65); }

        public void set(QuickFix.SecurityID value)
        { setField(value); }
        public QuickFix.SecurityID get(QuickFix.SecurityID  value)
        { getField(value); return value; }
        public QuickFix.SecurityID getSecurityID()
        { QuickFix.SecurityID value = new QuickFix.SecurityID();
          getField(value); return value; }
        public bool isSet(QuickFix.SecurityID field)
        { return isSetField(field); }
        public bool isSetSecurityID()
        { return isSetField(48); }

        public void set(QuickFix.IDSource value)
        { setField(value); }
        public QuickFix.IDSource get(QuickFix.IDSource  value)
        { getField(value); return value; }
        public QuickFix.IDSource getIDSource()
        { QuickFix.IDSource value = new QuickFix.IDSource();
          getField(value); return value; }
        public bool isSet(QuickFix.IDSource field)
        { return isSetField(field); }
        public bool isSetIDSource()
        { return isSetField(22); }

        public void set(QuickFix.SecurityType value)
        { setField(value); }
        public QuickFix.SecurityType get(QuickFix.SecurityType  value)
        { getField(value); return value; }
        public QuickFix.SecurityType getSecurityType()
        { QuickFix.SecurityType value = new QuickFix.SecurityType();
          getField(value); return value; }
        public bool isSet(QuickFix.SecurityType field)
        { return isSetField(field); }
        public bool isSetSecurityType()
        { return isSetField(167); }

        public void set(QuickFix.MaturityMonthYear value)
        { setField(value); }
        public QuickFix.MaturityMonthYear get(QuickFix.MaturityMonthYear  value)
        { getField(value); return value; }
        public QuickFix.MaturityMonthYear getMaturityMonthYear()
        { QuickFix.MaturityMonthYear value = new QuickFix.MaturityMonthYear();
          getField(value); return value; }
        public bool isSet(QuickFix.MaturityMonthYear field)
        { return isSetField(field); }
        public bool isSetMaturityMonthYear()
        { return isSetField(200); }

        public void set(QuickFix.MaturityDay value)
        { setField(value); }
        public QuickFix.MaturityDay get(QuickFix.MaturityDay  value)
        { getField(value); return value; }
        public QuickFix.MaturityDay getMaturityDay()
        { QuickFix.MaturityDay value = new QuickFix.MaturityDay();
          getField(value); return value; }
        public bool isSet(QuickFix.MaturityDay field)
        { return isSetField(field); }
        public bool isSetMaturityDay()
        { return isSetField(205); }

        public void set(QuickFix.PutOrCall value)
        { setField(value); }
        public QuickFix.PutOrCall get(QuickFix.PutOrCall  value)
        { getField(value); return value; }
        public QuickFix.PutOrCall getPutOrCall()
        { QuickFix.PutOrCall value = new QuickFix.PutOrCall();
          getField(value); return value; }
        public bool isSet(QuickFix.PutOrCall field)
        { return isSetField(field); }
        public bool isSetPutOrCall()
        { return isSetField(201); }

        public void set(QuickFix.StrikePrice value)
        { setField(value); }
        public QuickFix.StrikePrice get(QuickFix.StrikePrice  value)
        { getField(value); return value; }
        public QuickFix.StrikePrice getStrikePrice()
        { QuickFix.StrikePrice value = new QuickFix.StrikePrice();
          getField(value); return value; }
        public bool isSet(QuickFix.StrikePrice field)
        { return isSetField(field); }
        public bool isSetStrikePrice()
        { return isSetField(202); }

        public void set(QuickFix.OptAttribute value)
        { setField(value); }
        public QuickFix.OptAttribute get(QuickFix.OptAttribute  value)
        { getField(value); return value; }
        public QuickFix.OptAttribute getOptAttribute()
        { QuickFix.OptAttribute value = new QuickFix.OptAttribute();
          getField(value); return value; }
        public bool isSet(QuickFix.OptAttribute field)
        { return isSetField(field); }
        public bool isSetOptAttribute()
        { return isSetField(206); }

        public void set(QuickFix.ContractMultiplier value)
        { setField(value); }
        public QuickFix.ContractMultiplier get(QuickFix.ContractMultiplier  value)
        { getField(value); return value; }
        public QuickFix.ContractMultiplier getContractMultiplier()
        { QuickFix.ContractMultiplier value = new QuickFix.ContractMultiplier();
          getField(value); return value; }
        public bool isSet(QuickFix.ContractMultiplier field)
        { return isSetField(field); }
        public bool isSetContractMultiplier()
        { return isSetField(231); }

        public void set(QuickFix.CouponRate value)
        { setField(value); }
        public QuickFix.CouponRate get(QuickFix.CouponRate  value)
        { getField(value); return value; }
        public QuickFix.CouponRate getCouponRate()
        { QuickFix.CouponRate value = new QuickFix.CouponRate();
          getField(value); return value; }
        public bool isSet(QuickFix.CouponRate field)
        { return isSetField(field); }
        public bool isSetCouponRate()
        { return isSetField(223); }

        public void set(QuickFix.SecurityExchange value)
        { setField(value); }
        public QuickFix.SecurityExchange get(QuickFix.SecurityExchange  value)
        { getField(value); return value; }
        public QuickFix.SecurityExchange getSecurityExchange()
        { QuickFix.SecurityExchange value = new QuickFix.SecurityExchange();
          getField(value); return value; }
        public bool isSet(QuickFix.SecurityExchange field)
        { return isSetField(field); }
        public bool isSetSecurityExchange()
        { return isSetField(207); }

        public void set(QuickFix.Issuer value)
        { setField(value); }
        public QuickFix.Issuer get(QuickFix.Issuer  value)
        { getField(value); return value; }
        public QuickFix.Issuer getIssuer()
        { QuickFix.Issuer value = new QuickFix.Issuer();
          getField(value); return value; }
        public bool isSet(QuickFix.Issuer field)
        { return isSetField(field); }
        public bool isSetIssuer()
        { return isSetField(106); }

        public void set(QuickFix.EncodedIssuerLen value)
        { setField(value); }
        public QuickFix.EncodedIssuerLen get(QuickFix.EncodedIssuerLen  value)
        { getField(value); return value; }
        public QuickFix.EncodedIssuerLen getEncodedIssuerLen()
        { QuickFix.EncodedIssuerLen value = new QuickFix.EncodedIssuerLen();
          getField(value); return value; }
        public bool isSet(QuickFix.EncodedIssuerLen field)
        { return isSetField(field); }
        public bool isSetEncodedIssuerLen()
        { return isSetField(348); }

        public void set(QuickFix.EncodedIssuer value)
        { setField(value); }
        public QuickFix.EncodedIssuer get(QuickFix.EncodedIssuer  value)
        { getField(value); return value; }
        public QuickFix.EncodedIssuer getEncodedIssuer()
        { QuickFix.EncodedIssuer value = new QuickFix.EncodedIssuer();
          getField(value); return value; }
        public bool isSet(QuickFix.EncodedIssuer field)
        { return isSetField(field); }
        public bool isSetEncodedIssuer()
        { return isSetField(349); }

        public void set(QuickFix.SecurityDesc value)
        { setField(value); }
        public QuickFix.SecurityDesc get(QuickFix.SecurityDesc  value)
        { getField(value); return value; }
        public QuickFix.SecurityDesc getSecurityDesc()
        { QuickFix.SecurityDesc value = new QuickFix.SecurityDesc();
          getField(value); return value; }
        public bool isSet(QuickFix.SecurityDesc field)
        { return isSetField(field); }
        public bool isSetSecurityDesc()
        { return isSetField(107); }

        public void set(QuickFix.EncodedSecurityDescLen value)
        { setField(value); }
        public QuickFix.EncodedSecurityDescLen get(QuickFix.EncodedSecurityDescLen  value)
        { getField(value); return value; }
        public QuickFix.EncodedSecurityDescLen getEncodedSecurityDescLen()
        { QuickFix.EncodedSecurityDescLen value = new QuickFix.EncodedSecurityDescLen();
          getField(value); return value; }
        public bool isSet(QuickFix.EncodedSecurityDescLen field)
        { return isSetField(field); }
        public bool isSetEncodedSecurityDescLen()
        { return isSetField(350); }

        public void set(QuickFix.EncodedSecurityDesc value)
        { setField(value); }
        public QuickFix.EncodedSecurityDesc get(QuickFix.EncodedSecurityDesc  value)
        { getField(value); return value; }
        public QuickFix.EncodedSecurityDesc getEncodedSecurityDesc()
        { QuickFix.EncodedSecurityDesc value = new QuickFix.EncodedSecurityDesc();
          getField(value); return value; }
        public bool isSet(QuickFix.EncodedSecurityDesc field)
        { return isSetField(field); }
        public bool isSetEncodedSecurityDesc()
        { return isSetField(351); }

        public void set(QuickFix.QuoteEntryRejectReason value)
        { setField(value); }
        public QuickFix.QuoteEntryRejectReason get(QuickFix.QuoteEntryRejectReason  value)
        { getField(value); return value; }
        public QuickFix.QuoteEntryRejectReason getQuoteEntryRejectReason()
        { QuickFix.QuoteEntryRejectReason value = new QuickFix.QuoteEntryRejectReason();
          getField(value); return value; }
        public bool isSet(QuickFix.QuoteEntryRejectReason field)
        { return isSetField(field); }
        public bool isSetQuoteEntryRejectReason()
        { return isSetField(368); }

      };
    };
  };

}

